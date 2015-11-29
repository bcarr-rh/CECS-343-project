using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class MeettheDean : CardInterface
    {
        string thisImage;
        public MeettheDean()
        {
            thisImage = "Meet the Dean";
        }

        public override string Play(Player p)
        {

            if ((p.getCurrentRoom() == 12 || p.getCurrentRoom() == 15) && p.getLChip() > 2 && p.getCChip() > 2 && p.getIChip() > 2)
            {
                p.addQPoint(5);
                p.addExtraCard();
                return (p.getPlayerName() + " played " + thisImage + " for 5 Quality points and 1 game card");
            }
            p.discardPick();
            p.addQPoint(-2);
            return (p.getPlayerName() + " played " + thisImage + " FAILED: lose a card");

        }
        public override string getImage()
        {
            return thisImage;
        }
    }
}
