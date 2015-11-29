using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class CECS174 : CardInterface
    {
        string thisImage;
        public CECS174()
        {
            thisImage = "CECS 174";
        }

        public override string Play(Player p)
        {

            if (p.getCurrentRoom() == 14)
            {
                p.addLChip(1);
                return (p.getPlayerName() + " played Professor Murgolo's CECS 174 Class for 1 learning chip");
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
