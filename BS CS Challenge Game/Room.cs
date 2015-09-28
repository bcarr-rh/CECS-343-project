using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
namespace BS_CS_Challenge_Game
{
    class Room
    {
        private String name;
        private Button button1;
        private Button button2;
        private Button button3;
        private LinkedList<Room> nextTo;
        public Room(String n, Button b1, Button b2, Button b3)
        {
            name = n;
            button1 = b1;
            button2 = b2;
            button3 = b3;
            nextTo = new LinkedList<Room>();
        }

        public void addNextTo(Room r)
        {
            nextTo.AddLast(r);
        }
        public LinkedList<Room> getNextTo()
        {
            return nextTo;
        }
        public void MoveTo(int player)
        {
            Image playerImage;
            if (player == 0)
                playerImage = null;
            else if (player == 1)
                playerImage = null;
            else
                playerImage = null;
            if (button1.Visible.Equals(false))
                button1.BackgroundImage = playerImage;
            else if (button2.Visible.Equals(false))
                button1.BackgroundImage = playerImage;
            if (button1.Visible.Equals(false))
                button1.BackgroundImage = playerImage;
        }
    }
}
