using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class LearningtheRulesofSoccer : CardInterface
    {
        string thisImage;
        public LearningtheRulesofSoccer()
        {
            thisImage = "Learning the Rules of Soccer";
        }

        public override string Play(Player p)
        {

            if (p.getCurrentRoom() == 0 && p.getIChip() > 3)
            {
                p.addCChip(2);
                return (p.getPlayerName() + " played KIN 253" + thisImage + " for 2 craft chips");
            }
            p.setCurrentRoom(13);
            return (p.getPlayerName() + " played " + thisImage + " FAILED");

        }
        public override string getImage()
        {
            return thisImage;
        }
    }
}
