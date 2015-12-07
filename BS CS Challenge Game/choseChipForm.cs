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
    public partial class choseChipForm : Form
    {
        private Player currentPlayer;
        private string choice;
        public choseChipForm(int l, int c, int i, Object p)
        {
            currentPlayer = (Player)p;
            if (!currentPlayer.getAi()) { 
                InitializeComponent();
                if (i == 0)
                {
                button1.Enabled = false;
                }
                if (l == 0)
                {
                button3.Enabled = false;
                }
                if (c == 0)
                {
                button2.Enabled = false;
                }
            }
            else
            {
                if (i == 1)
                {
                    currentPlayer.addIChip(1);
                    choice = "1 Integrity Chip";
                }
                else if (l == 1)
                {
                    currentPlayer.addLChip(1);
                    choice = "1 Learning Chip";
                }
                else
                {
                    currentPlayer.addCChip(1);
                    choice = "1 Craft Chip";
                }
            }
        }

        public string getChoice()
        {
            return choice;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Learning Chip Action
        private void button3_Click(object sender, EventArgs e)
        {
            currentPlayer.addLChip(1);
            choice = "1 Learning Chip";
            button3.DialogResult = DialogResult.OK;
            this.Close();
        }
        //Craft Chip Action
        private void button2_Click_1(object sender, EventArgs e)
        {
            currentPlayer.addCChip(1);
            choice = "1 Craft Chip";
            button2.DialogResult = DialogResult.OK;
            this.Close();
        }
        //Integrity Chip Action
        private void button1_Click(object sender, EventArgs e)
        {
            currentPlayer.addIChip(1);
            choice = "1 Integrity Chip";
            button1.DialogResult = DialogResult.OK;
            this.Close();
        }

        
    }
}
