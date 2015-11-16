using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class PresstheRightFloor : CardInterface
    {
        string thisImage;
        public PresstheRightFloor()
        {
            thisImage = "Press the Right Floor";
        }

        public override string Play(Player p)
        {

            if (p.getCurrentRoom() == 16 && p.getLChip() > 3)
            {
                p.addCChip(2);
                return (p.getPlayerName() + " played " + thisImage + " for 2 craft chips");
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
