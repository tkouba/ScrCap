using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrCap
{
    public partial class FormImage : Form, IChildForm
    {
        private static string lastFolder = String.Empty;

        bool saved = false;

        public ToolStrip ToolBarStrip => toolStrip;

        public FormImage()
        {
            InitializeComponent();
        }

        public void SetImage(Image image)
        {
            picture.Image = image;
        }

        public void SaveImage()
        {
            if (String.IsNullOrEmpty(lastFolder))
                lastFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = lastFolder;
            saveFileDialog.Filter = "Portable Network Graphics (*.png)|*.png|Bitmap Files (*.bmp)|*.bmp|All Files (*.*)|*.*";
            saveFileDialog.DefaultExt = "png";
            saveFileDialog.FileName = Text;
            saveFileDialog.AddExtension = true;
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                string ext = Path.GetExtension(fileName);
                ImageFormat fmt = ImageFormat.Png;
                if (String.Equals(".bmp", ext, StringComparison.OrdinalIgnoreCase))
                    fmt = ImageFormat.Bmp;
                picture.Image.Save(fileName, fmt);
                Text = Path.GetFileName(fileName);
                lastFolder = Path.GetDirectoryName(fileName);
                saved = true;
            }
        }

        public void CopyImageToClipboard()
        {
            Clipboard.SetImage(picture.Image);
        }

        private void FormImage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saved)
            {
                string msg = String.Format("Captured image {0} unsaved. Save?", Text);
                DialogResult res = MessageBox.Show(this, msg, "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (res == DialogResult.Yes)
                {
                    SaveImage();
                }
                if (res == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void menuItemSave_Click(object sender, EventArgs e)
        {
            SaveImage();
        }

        private void menuItemClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuItemCopy_Click(object sender, EventArgs e)
        {
            CopyImageToClipboard();
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            SaveImage();
        }

        private void toolStripButtonCopy_Click(object sender, EventArgs e)
        {
            CopyImageToClipboard();
        }
    }
}
