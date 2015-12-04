using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class CECS277 : CardInterface
    {
        private string thisImage;

        public CECS277()
        {
            thisImage = "CECS277";
        }

        public override string getImage()
        {
            return thisImage;
        }

        public override string Play(Player p)
        {
            if (p.getCurrentRoom() == 17)
            {
                p.addCChip(2);
                return (p.getPlayerName() + " played CECS 277 Class for 2 Craft Chips");
            }
            return (p.getPlayerName() + " played " + thisImage + " FAILED");
        }
    }
}
