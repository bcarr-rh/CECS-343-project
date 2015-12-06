using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class ResearchCompilers : CardInterface
    {
        string thisImage;
        public ResearchCompilers()
        {
            thisImage = "Research Compilers";
        }

        public override string Play(Player p)
        {

            if (p.getCurrentRoom() == 7)
            {
                p.addLChip(1);
                return (p.getPlayerName() + " played " + thisImage + " for 1 learning chip");
            }
            p.addQPoint(-2);
            return (p.getPlayerName() + " played " + thisImage + " FAILED");

        }
        public override string getImage()
        {
            return thisImage;
        }
        public override bool DicardThisCard()
        {
            return false;
        }
        public override bool Check(Player p)
        {
            return (p.getCurrentRoom() == 7);
        }
    }
}
