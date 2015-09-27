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
            if (Screen.PrimaryScreen.Bounds.Width > 1670)
                this.Width = 1670;
            else
                this.Width = Screen.PrimaryScreen.Bounds.Width;
            if (Screen.PrimaryScreen.Bounds.Height > 2100)
                this.Height = 2000;
            else
                this.Height = Screen.PrimaryScreen.Bounds.Height - 100;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    PictureBox PictureBox1 = new PictureBox();
                    PictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                    // Add the new control to its parent's controls collection
                    PictureBox1.Height = 2000;
                    PictureBox1.Width = 1670;
                    if (Screen.PrimaryScreen.Bounds.Width > 1670)
                        this.Width = 1670;
                    else
                        this.Width = Screen.PrimaryScreen.Bounds.Width;
                    if (Screen.PrimaryScreen.Bounds.Height > 2100)
                        this.Height = 2000;
                    else
                        this.Height = Screen.PrimaryScreen.Bounds.Height - 100;
                    this.AutoScroll = true;
                    this.Controls.Add(PictureBox1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image" + ex.Message);
                }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void room()
        {

        }
    }
}
