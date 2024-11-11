using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrCap
{
    public partial class FormImage : Form
    {
        bool saved = false;

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
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Bitmap Files (*.bmp)|*.bmp|All Files (*.*)|*.*";
            saveFileDialog.DefaultExt = "bmp";
            saveFileDialog.FileName = $"{Text}.bmp";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                picture.Image.Save(fileName);
                Text = Path.GetFileName(fileName);
                saved = true;
            }
        }

        private void FormImage_FormClosing(object sender, FormClosingEventArgs e)
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
}
