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

        public override string getImage()
        {
            return thisImage;
        }

        public override string Play(Player p)
        {
            if (p.getCurrentRoom() == 18)
            {
                p.addCChip(4);
                return (p.getPlayerName() + " played CECS 285 Class for 4 Craft Chips");
            }
            return (p.getPlayerName() + " played " + thisImage + " FAILED");
        }
    }
}
