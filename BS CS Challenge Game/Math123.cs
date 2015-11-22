using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class Math123 : CardInterface
    {
        string thisImage;
        public Math123()
        {
            thisImage = "Math 123";
        }

        public override string Play(Player p)
        {

            if ((p.getCurrentRoom() == 17 || p.getCurrentRoom() == 14) && p.getLChip() > 4)
            {
                p.addQPoint(5);
                return (p.getPlayerName() + " played " + thisImage + " for 5 Quality Points!");
            }
            p.addQPoint(-3);
            p.discardPick();
            return (p.getPlayerName() + " played " + thisImage + " FAILED");

        }
        public override string getImage()
        {
            return thisImage;
        }
    }
}
