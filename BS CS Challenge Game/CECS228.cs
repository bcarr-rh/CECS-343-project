using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class CECS228 : CardInterface
    {
        private string thisImage;

        public CECS228()
        {
            thisImage = "CECS228";
        }

        public override string getImage()
        {
            return thisImage;
        }

        public override string Play(Player p)
        {
            if (p.getCurrentRoom() == 14)
            {
                p.addIChip(3);
                return (p.getPlayerName() + " played CECS 228 Class for 3 Integrity chips");
            }
            return (p.getPlayerName() + " played " + thisImage + " FAILED");
        }
    }
}
