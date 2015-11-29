using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class EnjoyingNature : CardInterface
    {
        string thisImage;
        public EnjoyingNature()
        {
            thisImage = "Enjoying Nature";
        }

        public override string Play(Player p)
        {

            if (p.getCurrentRoom() < 11)
            {
                p.addCChip(1);
                p.setCurrentRoom(20);
                return (p.getPlayerName() + " played " + thisImage + " for 1 crafting chip");
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
