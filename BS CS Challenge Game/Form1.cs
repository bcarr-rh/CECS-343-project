using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BS_CS_Challenge_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\Users\\Adonias\\Documents\\Visual Studio 2013\\Projects\\BS CS Challenge Game\\CECS-343-project\\BS CS Challenge Game";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PictureBox pictureBox1 = new PictureBox();
                pictureBox1.Image = new Bitmap()
                pictureBox1.Height = image.Height;
                pictureBox1.Width = image.Width;
            }
            
            
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Image image = Image.FromFile("C:\\Users\\Adonias\\Documents\\Visual Studio 2013\\Projects\\BS CS Challenge Game\\CECS-343-project\\BS CS Challenge Game\\CSULBMap3.png");
            //e.Graphics.DrawImage(image, 0, 0);
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {

        }
    }
}
