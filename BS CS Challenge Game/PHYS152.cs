using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class PHYS152 : CardInterface
    {
        private string thisImage;

        public PHYS152()
        {
            thisImage = "PHYS152";
        }

        public override bool Check(Player p)
        {
            return (p.getCurrentRoom() == 17);
        }

        public override bool DicardThisCard()
        {
            throw new NotImplementedException();
        }

        public override string getImage()
        {
            return thisImage;
        }

        public override string Play(Player p)
        {
            if ((p.getCurrentRoom() == 8 || p.getCurrentRoom() == 7) &&
                 p.getIChip() == 7)
            {
                p.addQPoint(3);
                choseChipForm chose = new choseChipForm(1, 1, 1, p);
                System.Windows.Forms.DialogResult dg = chose.ShowDialog();
                string temp = chose.getChoice();
                chose.Close();
                return (p.getPlayerName() + " played " + thisImage + " for 5 Quality Points and " + temp);
            }
            p.discardPick();
            return (p.getPlayerName() + " played " + thisImage + " FAILED");
        }
    }
}
