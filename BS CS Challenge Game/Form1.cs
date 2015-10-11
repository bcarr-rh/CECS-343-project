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
        
        private Room[] roomArray;
        private Player[] playerArray;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            roomArray = new Room[21];
            playerArray = new Player[3];
            if (Screen.PrimaryScreen.Bounds.Width > 1670)
                this.Width = 1670;
            else
                this.Width = Screen.PrimaryScreen.Bounds.Width;
            if (Screen.PrimaryScreen.Bounds.Height > 2100)
                this.Height = 2000;
            else
                this.Height = Screen.PrimaryScreen.Bounds.Height - 100;
            this.splitContainer1.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 3;
            this.splitContainer1.Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height / 3;


        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void room()
        {

        }

        private void button64_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            
            roomArray[0] = new Room("George Allen Field", button1, button2, button3);
            roomArray[1] = new Room("Japanese Garden", button6, button5, button4);
            roomArray[2] = new Room("Student Parking", button9, button8, button7);
            roomArray[3] = new Room("Pyramid", button12, button11, button10);
            roomArray[5] = new Room("Rec Center", button15, button14, button13);
            roomArray[6] = new Room("Forbidden Parking", button18, button17, button16);
            roomArray[4] = new Room("West Walkway", button63, button62, button61);
            roomArray[10] = new Room("East Walkway", button51, button50, button49);
            roomArray[11] = new Room("Computer Lab", button21, button20, button19);
            roomArray[14] = new Room("ECS 302", button24, button23, button22);
            roomArray[18] = new Room("Eat Club", button27, button26, button25);
            roomArray[19] = new Room("Conference Room", button30, button29, button28);
            roomArray[12] = new Room("North Hall", button33, button32, button31);
            roomArray[15] = new Room("South Hall", button36, button35, button34);
            roomArray[13] = new Room("Room Of Retirement", button39, button38, button37);
            roomArray[16] = new Room("Elevators", button42, button41, button40);
            roomArray[17] = new Room("ECS 308", button45, button44, button43);
            roomArray[20] = new Room("Lactation Lounge", button48, button47, button46);
            roomArray[7] = new Room("Library", button54, button53, button52);
            roomArray[8] = new Room("LA 5", button57, button56, button55);
            roomArray[9] = new Room("Bratwurst Hall", button60, button59, button58);
            roomArray[0].addNextTo(1);
            roomArray[0].addNextTo(3);
            roomArray[0].addNextTo(5);
            roomArray[0].addNextTo(4);
            roomArray[1].addNextTo(0);
            roomArray[1].addNextTo(3);
            roomArray[1].addNextTo(2);
            roomArray[2].addNextTo(1);
            roomArray[2].addNextTo(3);
            roomArray[2].addNextTo(5);
            roomArray[2].addNextTo(6);
            roomArray[3].addNextTo(0);
            roomArray[3].addNextTo(1);
            roomArray[3].addNextTo(2);
            roomArray[3].addNextTo(5);
            roomArray[4].addNextTo(0);
            roomArray[4].addNextTo(5);
            roomArray[4].addNextTo(11);
            roomArray[4].addNextTo(12);
            roomArray[4].addNextTo(13);
            roomArray[4].addNextTo(7);
            roomArray[5].addNextTo(0);
            roomArray[5].addNextTo(3);
            roomArray[5].addNextTo(2);
            roomArray[5].addNextTo(6);
            roomArray[5].addNextTo(11);
            roomArray[5].addNextTo(14);
            roomArray[5].addNextTo(4);
            roomArray[6].addNextTo(2);
            roomArray[6].addNextTo(5);
            roomArray[6].addNextTo(14);
            roomArray[6].addNextTo(18);
            roomArray[6].addNextTo(19);
            roomArray[6].addNextTo(10);
            roomArray[7].addNextTo(4);
            roomArray[7].addNextTo(13);
            roomArray[7].addNextTo(8);
            roomArray[8].addNextTo(7);
            roomArray[8].addNextTo(13);
            roomArray[8].addNextTo(16);
            roomArray[8].addNextTo(17);
            roomArray[8].addNextTo(9);
            roomArray[9].addNextTo(8);
            roomArray[9].addNextTo(17);
            roomArray[9].addNextTo(20);
            roomArray[9].addNextTo(10);
            roomArray[10].addNextTo(6);
            roomArray[10].addNextTo(9);
            roomArray[10].addNextTo(20);
            roomArray[10].addNextTo(15);
            roomArray[10].addNextTo(19);
            roomArray[11].addNextTo(4);
            roomArray[11].addNextTo(5);
            roomArray[11].addNextTo(14);
            roomArray[11].addNextTo(12);
            roomArray[12].addNextTo(4);
            roomArray[12].addNextTo(11);
            roomArray[12].addNextTo(14);
            roomArray[12].addNextTo(15);
            roomArray[12].addNextTo(16);
            roomArray[12].addNextTo(13);
            roomArray[13].addNextTo(12);
            roomArray[13].addNextTo(16);
            roomArray[13].addNextTo(4);
            roomArray[13].addNextTo(7);
            roomArray[13].addNextTo(8);
            roomArray[14].addNextTo(5);
            roomArray[14].addNextTo(6);
            roomArray[14].addNextTo(18);
            roomArray[14].addNextTo(15);
            roomArray[14].addNextTo(12);
            roomArray[14].addNextTo(11);
            roomArray[15].addNextTo(12);
            roomArray[15].addNextTo(14);
            roomArray[15].addNextTo(18);
            roomArray[15].addNextTo(19);
            roomArray[15].addNextTo(10);
            roomArray[15].addNextTo(20);
            roomArray[15].addNextTo(17);
            roomArray[16].addNextTo(12);
            roomArray[16].addNextTo(13);
            roomArray[16].addNextTo(17);
            roomArray[16].addNextTo(8);
            roomArray[17].addNextTo(15);
            roomArray[17].addNextTo(16);
            roomArray[17].addNextTo(20);
            roomArray[17].addNextTo(9);
            roomArray[17].addNextTo(8);
            roomArray[18].addNextTo(6);
            roomArray[18].addNextTo(19);
            roomArray[18].addNextTo(14);
            roomArray[18].addNextTo(15);
            roomArray[19].addNextTo(6);
            roomArray[19].addNextTo(18);
            roomArray[19].addNextTo(15);
            roomArray[19].addNextTo(10);
            roomArray[20].addNextTo(17);
            roomArray[20].addNextTo(15);
            roomArray[20].addNextTo(10);
            roomArray[20].addNextTo(9);



        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void DrawCard_Click(object sender, EventArgs e)
        {

        }

        private void MoveButton_Click(object sender, EventArgs e)
        {
            String Room = roomsList.SelectedItem.ToString();
           // playerArray[0];
        }
    }
}
