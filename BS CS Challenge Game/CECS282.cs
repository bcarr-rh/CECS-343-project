using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class CECS282 : CardInterface
    {
        private string thisImage;

        public CECS282()
        {
            thisImage = "CECS282";
        }

        public override string getImage()
        {
            return thisImage;
        }

        public override string Play(Player p)
        {
            if (p.getCurrentRoom() == 11)
            {
                p.addCChip(2);
                return (p.getPlayerName() + " played CECS 282 Class for 2 Craft Chips");
            }
            return (p.getPlayerName() + " played " + thisImage + " FAILED");
        }
    }
}
