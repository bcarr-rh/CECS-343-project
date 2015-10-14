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
            /**
            if (Screen.PrimaryScreen.Bounds.Width > 1670)
                this.Width = 1670;
            else
                this.Width = Screen.PrimaryScreen.Bounds.Width;
            if (Screen.PrimaryScreen.Bounds.Height > 2100)
                this.Height = 2000;
            else 
                this.Height = Screen.PrimaryScreen.Bounds.Height - 100;
             **/
            this.splitContainer1.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 3;
            this.splitContainer1.Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height / 3;
            playerArray[0] = new Player("John", 2);
            playerArray[1] = new Player("Kyle", 2);
            playerArray[2] = new Player("Martha", 2);
            Random rnd = new Random();
            // shuffle player array
            int n = playerArray.Length;
            while (n > 1)
            {
                int k = rnd.Next(n--);
                Player temp = playerArray[n];
                playerArray[n] = playerArray[k];
                playerArray[k] = temp;
            }

            roomArray[0] = new Room("George Allen Field",0, button1, button2, button3);
            roomArray[1] = new Room("Japanese Garden",1, button6, button5, button4);
            roomArray[2] = new Room("Student Parking",2, button9, button8, button7);
            roomArray[3] = new Room("Pyramid",3, button12, button11, button10);
            roomArray[5] = new Room("Rec Center",5, button15, button14, button13);
            roomArray[6] = new Room("Forbidden Parking",6, button18, button17, button16);
            roomArray[4] = new Room("West Walkway",4, button63, button62, button61);
            roomArray[10] = new Room("East Walkway",10, button51, button50, button49);
            roomArray[11] = new Room("Computer Lab",11, button21, button20, button19);
            roomArray[14] = new Room("ECS 302",14, button24, button23, button22);
            roomArray[18] = new Room("Eat Club",18, button27, button26, button25);
            roomArray[19] = new Room("Conference Room",19, button30, button29, button28);
            roomArray[12] = new Room("North Hall",12, button33, button32, button31);
            roomArray[15] = new Room("South Hall",15, button36, button35, button34);
            roomArray[13] = new Room("Room Of Retirement",13, button39, button38, button37);
            roomArray[16] = new Room("Elevators",16, button42, button41, button40);
            roomArray[17] = new Room("ECS 308",17, button45, button44, button43);
            roomArray[20] = new Room("Lactation Lounge",20, button48, button47, button46);
            roomArray[7] = new Room("Library",7, button54, button53, button52);
            roomArray[8] = new Room("LA 5",8, button57, button56, button55);
            roomArray[9] = new Room("Bratwurst Hall",9, button60, button59, button58);
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
            roomArray[4].addNextTo(12);
            roomArray[4].addNextTo(7);
            roomArray[5].addNextTo(0);
            roomArray[5].addNextTo(3);
            roomArray[5].addNextTo(2);
            roomArray[5].addNextTo(6);
            roomArray[5].addNextTo(4);
            roomArray[6].addNextTo(2);
            roomArray[6].addNextTo(5);
            roomArray[6].addNextTo(10);
            roomArray[7].addNextTo(4);
            roomArray[7].addNextTo(8);
            roomArray[8].addNextTo(7);
            roomArray[8].addNextTo(16);
            roomArray[8].addNextTo(9);
            roomArray[9].addNextTo(8);
            roomArray[9].addNextTo(10);
            roomArray[10].addNextTo(6);
            roomArray[10].addNextTo(9);
            roomArray[10].addNextTo(15);
            roomArray[11].addNextTo(12);
            roomArray[12].addNextTo(4);
            roomArray[12].addNextTo(11);
            roomArray[12].addNextTo(14);
            roomArray[12].addNextTo(15);
            roomArray[12].addNextTo(16);
            roomArray[12].addNextTo(13);
            roomArray[14].addNextTo(15);
            roomArray[14].addNextTo(12);
            roomArray[15].addNextTo(12);
            roomArray[15].addNextTo(14);
            roomArray[15].addNextTo(18);
            roomArray[15].addNextTo(19);
            roomArray[15].addNextTo(10);
            roomArray[15].addNextTo(20);
            roomArray[15].addNextTo(17);
            roomArray[16].addNextTo(12);
            roomArray[16].addNextTo(8);
            roomArray[17].addNextTo(15);
            roomArray[18].addNextTo(15);
            roomArray[19].addNextTo(15);
            roomArray[20].addNextTo(15);
            roomsList.Items.Clear();
            foreach (int s in roomArray[playerArray[0].getCurrentRoom()].getNextTo())
            {
                roomsList.Items.Add(roomArray[s].getRoomName());
            }
            roomArray[playerArray[0].getCurrentRoom()].MoveTo(playerArray[0].getPlayerName());
            roomArray[playerArray[1].getCurrentRoom()].MoveTo(playerArray[1].getPlayerName());
            roomArray[playerArray[2].getCurrentRoom()].MoveTo(playerArray[2].getPlayerName());
            PlayerIndicator.Text = "Human player is " + playerArray[0].getPlayerName();
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
            try {
                String Room = roomsList.SelectedItem.ToString();
                foreach (int s in roomArray[playerArray[0].getCurrentRoom()].getNextTo())
                {
                    if (roomArray[s].getRoomName().Equals(Room))
                    {
                        roomArray[playerArray[0].getCurrentRoom()].MoveOut(playerArray[0].getPlayerName());
                        playerArray[0].setCurrentRoom(roomArray[s].getRoomNum());
                        roomArray[s].MoveTo(playerArray[0].getPlayerName());
                        break;
                    }

                }
            }
            catch(NullReferenceException) {
                MessageBox.Show("Select a room to move to");
            }
            //AI LOGIC
            Random rnd = new Random();
            //AI One
            roomArray[playerArray[1].getCurrentRoom()].MoveOut(playerArray[1].getPlayerName());
            int ai1RndSize = roomArray[playerArray[1].getCurrentRoom()].getNextTo().Count() - 1;
            int ai1 = roomArray[playerArray[1].getCurrentRoom()].getNextTo().First();
            playerArray[1].setCurrentRoom(roomArray[ai1].getRoomNum());
            roomArray[ai1].MoveTo(playerArray[1].getPlayerName());
            //AI two
            roomArray[playerArray[2].getCurrentRoom()].MoveOut(playerArray[2].getPlayerName());
            int ai2RndSize = roomArray[playerArray[2].getCurrentRoom()].getNextTo().Count() - 1;
            int ai2 = roomArray[playerArray[2].getCurrentRoom()].getNextTo().Last();
            playerArray[2].setCurrentRoom(roomArray[ai2].getRoomNum());
            roomArray[ai2].MoveTo(playerArray[2].getPlayerName());
            //reset roomsList
            roomsList.Items.Clear();
            foreach (int s in roomArray[playerArray[0].getCurrentRoom()].getNextTo())
            {
                roomsList.Items.Add(roomArray[s].getRoomName());
            }
            MoveButton.Enabled = false;
        }

        private void roomsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            MoveButton.Enabled = true;
        }

        private void button41_Click(object sender, EventArgs e)
        {

        }

        private void button40_Click(object sender, EventArgs e)
        {

        }

        private void button42_Click(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
