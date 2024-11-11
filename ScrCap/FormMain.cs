using AdvancedSharpAdbClient.Models;
using AdvancedSharpAdbClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Microsoft.Win32;

namespace ScrCap
{
    public partial class FormMain : Form
    {

        System.Threading.Timer timer;
        AdbClient adbClient;

        public FormMain()
        {
            InitializeComponent();
            timer = new System.Threading.Timer(WinClosedCallback, null, Timeout.Infinite, Timeout.Infinite);
        }

        void WinClosedCallback(object state)
        {
            BeginInvoke((Action)(() => RefreshMenu()));
        }

        private void RefreshMenu()
        {
            menuItemSave.Enabled =
                menuItemClose.Enabled =
                toolStripButtonSave.Enabled =
                MdiChildren.Length > 0;
        }

        private async void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                AdbServerStatus status = await AdbServer.Instance.GetStatusAsync(CancellationToken.None);
                if (!status.IsRunning)
                {
                    statusLabel.Text = "Starting adb server.";

                    // To find Android SDK(https://github.com/vurdalakov/adbdotnet)
                    string path = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Android SDK Tools", "Path", null)?.ToString();
                    if (String.IsNullOrEmpty(path))
                    {
                        path = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Wow6432Node\Android SDK Tools", "Path", null)?.ToString();
                    }
                    if (String.IsNullOrEmpty(path))
                    {
                        string xamKey = Environment.GetEnvironmentVariable(@"XAMARIN_ANDROID_REGKEY");
                        if (!String.IsNullOrEmpty(xamKey))
                        {
                            path = Registry.GetValue($@"HKEY_CURRENT_USER\{xamKey}", "AndroidSdkDirectory", null)?.ToString();
                        }
                    }
                    if (String.IsNullOrEmpty(path) && System.IO.Directory.Exists(@"C:\Program Files (x86)\Android\android-sdk"))
                    {
                        path = @"C:\Program Files (x86)\Android\android-sdk"; // Direct SDK path
                    }
                    path = System.IO.Path.Combine(path, @"platform-tools\adb.exe");

                    if (!System.IO.File.Exists(path))
                    {
                        statusLabel.Text = "Can't find adb.exe.";
                    }
                    else
                    {
                        StartServerResult result = await AdbServer.Instance.StartServerAsync(path, false, CancellationToken.None);
                        if (result != StartServerResult.Started)
                        {
                            statusLabel.Text = "Can't start adb server.";
                        }
                        status = await AdbServer.Instance.GetStatusAsync(CancellationToken.None);
                    }
                }
                if (status.IsRunning)
                {
                    statusLabel.Text = String.Format("Version {0} of the adb daemon is running.", status.Version);
                    adbClient = new AdbClient();
                    adbClient.Connect("127.0.0.1");
                }
                else
                {
                    statusLabel.Text = "Adb server is not running.";
                }
            }
            catch (Exception ex)
            {
                statusLabel.Text = ex.Message;
            }
        }

        async Task CaptureScreen()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                DeviceData deviceData = adbClient.GetDevices().FirstOrDefault(); // Get first connected device
                if (deviceData.State == DeviceState.Online)
                {
                    using (Framebuffer framebuffer = await adbClient.GetFrameBufferAsync(deviceData, CancellationToken.None))
                    {
                        if (framebuffer != null)
                        {
                            Image image = framebuffer.ToImage();
                            FormImage childForm = new FormImage();
                            childForm.SetImage(image);
                            childForm.MdiParent = this;
                            childForm.FormClosed += ChildForm_FormClosed;
                            childForm.Text = $"{deviceData.Name}-{DateTime.Now:yyyyMMdd-HHmmss}";
                            childForm.Show();
                            statusLabel.Text = String.Format("Image captured from {0} at {1}", deviceData.Name, DateTime.Now);
                        }
                        else
                        {
                            statusLabel.Text = "Can't capture screen.";
                        }
                    }
                }
                else
                {
                    statusLabel.Text = String.Format("Device state {0}, can't continue.", deviceData.State);
                }
            }
            catch (Exception ex)
            {
                statusLabel.Text = ex.Message;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (sender is Form)
            {
                ((Form)sender).FormClosed -= ChildForm_FormClosed;
            }
            timer.Change(100, Timeout.Infinite);
        }

        private async void menuItemCapture_Click(object sender, EventArgs e)
        {
            await CaptureScreen();
        }

        private async void toolStripButtonCapture_Click(object sender, EventArgs e)
        {
            await CaptureScreen();
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuItemCascade_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void menuItemTileVert_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void menuItemTileHorz_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void menuItemCloseAll_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void menuItemArrangeIcons_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void FormMain_MdiChildActivate(object sender, EventArgs e)
        {
            RefreshMenu();
        }

        private void menuItemSave_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
            {
                (MdiChildren[0] as FormImage)?.SaveImage();
            }
        }

        private void menuItemClose_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
            {
                (MdiChildren[0] as Form)?.Close();
            }
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
            {
                (MdiChildren[0] as FormImage)?.SaveImage();
            }
        }
    }
}
