using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class ParkingViolation : CardInterface
    {
        string thisImage;
        public ParkingViolation()
        {
            thisImage = "Parking Violation";
        }

        public override string Play(Player p)
        {

            if (p.getCurrentRoom() == 6)
            {
                p.addLChip(2);
                p.discardPick();
                return (p.getPlayerName() + " played " + thisImage + " for 2 learning chips");
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
