using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class MaketheDeansList : CardInterface
    {
        string thisImage;
        public MaketheDeansList()
        {
            thisImage = "Make the Dean's List";
        }

        public override string Play(Player p)
        {

            if ((p.getCurrentRoom() == 12 || p.getCurrentRoom() == 15) && p.getLChip() > 5)
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
    }
}
