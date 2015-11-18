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
    public partial class PopupForm : Form
    {
        CardInterface showCard;
        Player HumanPlayer;

        public PopupForm()
        {
            InitializeComponent();
            
        }
        public void setHand(Object s, Object h)
        {
            showCard = (CardInterface)s;
            HumanPlayer = (Player)h;
        }

        public Object getCard()
        {
            return showCard;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.DialogResult = DialogResult.OK;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            showCard = HumanPlayer.getCard(showCard);
            pictureBox2.ImageLocation = "C:\\Users\\adoni\\Documents\\Visual Studio 2015\\Projects\\CECS-343-project\\BS CS Challenge Game\\Resources\\" + showCard.getImage() + ".JPG";

        }
    }
}
