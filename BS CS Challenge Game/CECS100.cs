using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class CECS100 : CardInterface
    {
        string thisImage;
        public CECS100()
        {
            thisImage = "CECS 100";
        }

        public override string Play(Player p)
        {

            if (p.getCurrentRoom() == 17)
            {
                p.addCChip(1);
                return (p.getPlayerName() + " played " + thisImage + " for 1 craft chip");
            }
            p.addQPoint(-2);
            return (p.getPlayerName() + " played " + thisImage + " FAILED");

        }
        public override string getImage()
        {
            return thisImage;
        }
        public override bool DicardThisCard()
        {
            return true;
        }
        public override bool Check(Player p)
        {
            return (p.getCurrentRoom() == 17);
        }
    }
}
