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
        private Room GAField;
        private Room JapGarden;
        private Room StudentParking;
        private Room Pyramid;
        private Room RecCenter;
        private Room ForbiddenParking;
        private Room WestWalk;
        private Room EastWalk;
        private Room CompLab;
        private Room Ecs302;
        private Room EatClub;
        private Room ConRoom;
        private Room NorthHall;
        private Room SouthHall;
        private Room RoomOfRetirement;
        private Room Elevators;
        private Room Ecs308;
        private Room LactationLounge;
        private Room Library;
        private Room LA5;
        private Room BratwurstHall;

        public Form1()
        {
            InitializeComponent();
            GAField = new Room("George Allen Field", button1, button2, button3);
            JapGarden = new Room("Japanese Garden", button6, button5, button4);
            StudentParking = new Room("Student Parking", button9, button8, button7);
            Pyramid = new Room("Pyramid", button12, button11, button10);
            RecCenter = new Room("Rec Center", button15, button14, button13);
            ForbiddenParking = new Room("Forbidden Parking", button18, button17, button16);
            WestWalk = new Room("West Walkway", button63, button62, button61);
            EastWalk = new Room("East Walkway", button51, button50, button49);
            CompLab = new Room("Computer Lab", button21, button20, button19);
            Ecs302 = new Room("ECS 302", button24, button23, button22);
            EatClub = new Room("Eat Club", button27, button26, button25);
            ConRoom = new Room("Conference Room", button30, button29, button28);
            NorthHall = new Room("North Hall", button33, button32, button31);
            SouthHall = new Room("South Hall", button36, button35, button34);
            RoomOfRetirement = new Room("Room Of Retirement", button39, button38, button37);
            Elevators = new Room("Elevators", button42, button41, button40);
            Ecs308 = new Room("ECS", button45, button44, button43);
            LactationLounge = new Room("Lactation Lounge", button48, button47, button46);
            Library = new Room("Library", button54, button53, button52);
            LA5 = new Room("LA 5", button57, button56, button55);
            BratwurstHall = new Room("Bratwurst Hall", button60, button59, button58);
            GAField.addNextTo(JapGarden);
            GAField.addNextTo(Pyramid);
            GAField.addNextTo(RecCenter);
            GAField.addNextTo(WestWalk);
            JapGarden.addNextTo(GAField);
            JapGarden.addNextTo(Pyramid);
            JapGarden.addNextTo(StudentParking);
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

            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void room()
        {

        }
    }
}
