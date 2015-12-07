using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BS_CS_Challenge_Game
{
    class choseChip : Form
    {
        string choice;
        Label lblMessage;
        Button integrityChipButton;
        Button craftChipButton;
        Button learningChipButton;
        //will take in the data and make a person chose the available chips and update choice with the decision
        public choseChip(int l, int c, int i, Player p)
        {
            if (p.getAi())
            {
                p.addLChip(l);
                this.Close();
            }
            choice = "";
            lblMessage = new Label();
            integrityChipButton = new Button();
            craftChipButton = new Button();
            learningChipButton = new Button();
            integrityChipButton.Text = "Integrity Chip";
            craftChipButton.Text = "Craft Chip";
            learningChipButton.Text = "Learning Chip";
            lblMessage.Text = "Choose a chip";
            lblMessage.Size = new System.Drawing.Size(413, 82);
            lblMessage.Font = new System.Drawing.Font(lblMessage.Font.FontFamily, 24);

            integrityChipButton.Size = new System.Drawing.Size(120, 30);
            integrityChipButton.Location = new System.Drawing.Point((ClientRectangle.Width - 
                integrityChipButton.Size.Width) / 2, ClientRectangle.Height - 35);
            Controls.AddRange(new System.Windows.Forms.Control[] { this.integrityChipButton });

            craftChipButton.Size = new System.Drawing.Size(120, 30);
            craftChipButton.Location = new System.Drawing.Point((ClientRectangle.Width -
                craftChipButton.Size.Width) / 2, ClientRectangle.Height - 105);
            Controls.AddRange(new System.Windows.Forms.Control[] { this.craftChipButton });

            learningChipButton.Size = new System.Drawing.Size(120, 30);
            learningChipButton.Location = new System.Drawing.Point((ClientRectangle.Width -
                learningChipButton.Size.Width) / 2, ClientRectangle.Height - 175);
            Controls.AddRange(new System.Windows.Forms.Control[] { this.learningChipButton});
            learningChipButton.Click += new System.EventHandler(integrityChipButton_Click);
            learningChipButton.Click += new System.EventHandler(learningChipButton_Click);
            craftChipButton.Click += new System.EventHandler(craftChipButton_Click);
            this.Controls.Add(lblMessage);
            if(i == 0)
            {
                integrityChipButton.Enabled = false;
            }
            if(l == 0)
            {
                learningChipButton.Enabled = false;
            }
            if(c == 0)
            {
                craftChipButton.Enabled = false;
            }
            this.Show();
        }
        //returns a string in format "# blank chip"
        public string getChoice()
        {
            return choice;
        }

        private void integrityChipButton_Click(object sender, EventArgs e)
        {
            choice = "1 Integrity Chip";
            integrityChipButton.DialogResult = DialogResult.OK;
            //this.Close();
        }

        private void craftChipButton_Click(object sender, EventArgs e)
        {
            choice = "1 Craft Chip";
            craftChipButton.DialogResult = DialogResult.OK;
            //this.Close();
        }

        private void learningChipButton_Click(object sender, EventArgs e)
        {
            choice = "1 Learning Chip";
            learningChipButton.DialogResult = DialogResult.OK;
            //this.Close();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // choseChip
            // 
            this.ClientSize = new System.Drawing.Size(1224, 734);
            this.Name = "choseChip";
            this.ResumeLayout(false);

        }
    }
}
