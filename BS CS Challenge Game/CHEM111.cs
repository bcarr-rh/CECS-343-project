using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class CHEM111 : CardInterface
    {
        string thisImage;
        public CHEM111()
        {
            thisImage = "CHEM 111";
        }

        public override string Play(Player p)
        {

            if (p.getCurrentRoom() < 10 && p.getCurrentRoom() > 2 && p.getCurrentRoom() != 4 && p.getCurrentRoom() != 6 && p.getCChip() > 5)
            {
                p.addQPoint(5);
                return (p.getPlayerName() + " played " + thisImage + " for 5 Quality Points");
            }
            p.setCurrentRoom(2);
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
            return (p.getCurrentRoom() < 10 && p.getCurrentRoom() > 2 && p.getCurrentRoom() != 4 && p.getCurrentRoom() != 6 && p.getCChip() > 5);
        }
    }
}
