using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class Math122 : CardInterface
    {
        string thisImage;
        public Math122()
        {
            thisImage = "MATH 122";
        }

        public override string Play(Player p)
        {

            if (p.getCurrentRoom() == 7)
            {
                choseChipForm chose = new choseChipForm(1, 0, 1, p);
                System.Windows.Forms.DialogResult dg = chose.ShowDialog();
                string temp = chose.getChoice();
                return (p.getPlayerName() + " played " + thisImage + " for " + temp);
            }
            p.addQPoint(-2);
            return (p.getPlayerName() + " played " + thisImage + " FAILED");

        }
        public override string getImage()
        {
            return thisImage;
        }
    }
}
