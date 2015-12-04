using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class ENGL317 : CardInterface
    {
        private string thisImage;

        public ENGL317()
        {
            thisImage = "ENGL317";
        }

        public override string getImage()
        {
            return thisImage;
        }

        public override string Play(Player p)
        {
            if (p.getCurrentRoom() == 8)
            {
                p.addCChip(2);
                return (p.getPlayerName() + " played ENGL 317 Class for 2 Craft chips");
            }
            return (p.getPlayerName() + " played " + thisImage + " FAILED");
        }
    }
}
