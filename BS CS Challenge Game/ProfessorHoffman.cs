using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class ProfessorHoffman : CardInterface
    {
        string thisImage;
        public ProfessorHoffman()
        {
            thisImage = "Professor Hoffman";
        }

        public override string Play(Player p)
        {

            if (p.getCurrentRoom() > 10 && p.getLChip() > 2)
            {
                p.addQPoint(5);
                p.addExtraCard();
                p.addExtraCard();
                return (p.getPlayerName() + " played " + thisImage + " for 5 Quality Points and 2 game cards");
            }
            p.addQPoint(-5);
            p.setCurrentRoom(20);
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
            return (p.getCurrentRoom() > 10 && p.getLChip() > 2);
        }
    }
}
