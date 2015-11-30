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
            /*if (p.getCurrentRoom() == 14)
            {
                p.addLChip(1);
                return (p.getPlayerName() + " played Professor Murgolo's CECS 174 Class for 1 learning chip");
            }*/
            return (p.getPlayerName() + " played " + thisImage + " FAILED");
        }
    }
}
