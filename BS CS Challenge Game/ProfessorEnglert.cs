using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class ProfessorEnglert : CardInterface
    {
        string thisImage;
        public ProfessorEnglert()
        {
            thisImage = "Professor Englert";
        }

        public override string Play(Player p)
        {

            if (p.getCurrentRoom() == 19 && p.getIChip() > 2)
            {
                choseChipForm chose = new choseChipForm(1, 1, 1, p);
                System.Windows.Forms.DialogResult dg = chose.ShowDialog();
                string temp = chose.getChoice();
                return (p.getPlayerName() + " played " + thisImage + " for " + temp);
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
            return (p.getCurrentRoom() == 19 && p.getIChip() > 2);
        }
    }
}
