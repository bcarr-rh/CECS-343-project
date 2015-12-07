using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class ANewLaptop : CardInterface
    {
        string thisImage;
        public ANewLaptop()
        {
            thisImage = "A New Laptop";
        }

        public override string Play(Player p)
        {
            if (p.getCurrentRoom() == 11 && p.getIChip() > 3)
            {
                p.addQPoint(3);
                choseChipForm chose = new choseChipForm(1, 1, 1, p);
                string temp = chose.getChoice();
                if (!p.getAi())
                {   
                    System.Windows.Forms.DialogResult dg = chose.ShowDialog();
                    chose.Close();
                }
                return (p.getPlayerName() + " played " + thisImage + " for 3 Quality Points and " + temp);
            }
            p.discardPick();
            p.addQPoint(-2);
            return (p.getPlayerName() + " played " + thisImage + " FAILED");

        }
        public override string getImage()
        {
            return thisImage;
        }
        public override bool DicardThisCard()
        {
            return false;
        }
        public override bool Check(Player p)
        {
            return (p.getCurrentRoom() == 11 && p.getIChip() > 3);
        }
    }
}
