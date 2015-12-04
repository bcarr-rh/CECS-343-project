using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class PHYS152 : CardInterface
    {
        private string thisImage;

        public PHYS152()
        {
            thisImage = "PHYS152";
        }

        public override string getImage()
        {
            return thisImage;
        }

        public override string Play(Player p)
        {
            if (p.getCurrentRoom() == 17)
            {
                p.addIChip(3);
                return (p.getPlayerName() + " played PHYS 152 Class for 3 Integrity chips");
            }
            return (p.getPlayerName() + " played " + thisImage + " FAILED");
        }
    }
}
