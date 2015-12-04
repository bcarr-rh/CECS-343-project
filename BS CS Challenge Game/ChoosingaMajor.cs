using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class ChoosingaMajor : CardInterface
    {
        string thisImage;
        public ChoosingaMajor()
        {
            thisImage = "Choosing a Major";
        }

        public override string Play(Player p)
        {

            if (p.getCurrentRoom() == 19 && p.getIChip() > 2)
            {
                p.addQPoint(5);
                return (p.getPlayerName() + " played " + thisImage + " for 5 Quality Points!");
            }
            p.addQPoint(-3);
            return (p.getPlayerName() + " played " + thisImage + " FAILED: Lose 3 Quality Points");

        }
        public override string getImage()
        {
            return thisImage;
        }
    }
}
