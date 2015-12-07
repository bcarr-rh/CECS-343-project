using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class CECS285 : CardInterface
    {
        private string thisImage;

        public CECS285()
        {
            thisImage = "CECS285";
        }

        public override bool Check(Player p)
        {
            return ((p.getCurrentRoom() == 18 || p.getCurrentRoom() == 1) && p.getLChip() >= 6);
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
            if ((p.getCurrentRoom() == 18 || p.getCurrentRoom() == 1) && p.getLChip() >= 6)
            {
                p.addQPoint(5);
                choseChipForm chose = new choseChipForm(1, 1, 1, p);
                System.Windows.Forms.DialogResult dg = chose.ShowDialog();
                string temp = chose.getChoice();
                chose.Close();
                return (p.getPlayerName() + " played " + thisImage + " for 5 Quality Points and " + temp);
            }
            p.addQPoint(-3);
            return (p.getPlayerName() + " played " + thisImage + " FAILED");
        }
    }
}
