using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        private Bitmap _image = null;
        public int scaleIm = 2;
        private Bitmap image
        {
            get { return _image; }
            set
            {
                (_image as IDisposable)?.Dispose();
                _image = value;
            }
        }
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 f)
        {
            InitializeComponent();          
        }

        private void menuStrip1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() != DialogResult.OK)
                return;
            ShowPicture(dialog.FileName);
        }
        public void ShowPicture(string fileName)
        {
            image = new Bitmap(fileName);
            AutoScroll = true;
            AutoScrollMinSize = new Size(image.Size.Width * scaleIm, image.Size.Height * scaleIm);
            Invalidate();
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            if (image != null)
                e.Graphics.DrawImage(image,
                    AutoScrollPosition.X,
                    AutoScrollPosition.Y,
                    image.Width * scaleIm, image.Height * scaleIm);
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
