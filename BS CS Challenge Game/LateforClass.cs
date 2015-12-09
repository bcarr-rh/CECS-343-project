using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class LateforClass : CardInterface
    {
        string thisImage;
        public LateforClass()
        {
            thisImage = "Late for Class";
        }

        public override string Play(Player p)
        {

            if (p.getCurrentRoom() != 6 && p.getCurrentRoom() < 11)
            {
                p.addCChip(1);
                p.setCurrentRoom(20);
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
            return false;
        }
        public override bool Check(Player p)
        {
            return (p.getCurrentRoom() != 6 && p.getCurrentRoom() < 11);
        }
    }
}
