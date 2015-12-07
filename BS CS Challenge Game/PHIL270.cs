using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class PHIL270 : CardInterface
    {
        private string thisImage;

        public PHIL270()
        {
            thisImage = "PHIL270";
        }

        public override bool Check(Player p)
        {
            return (p.getCurrentRoom() == 19);
        }

        public override bool DicardThisCard()
        {
            throw new NotImplementedException();
        }

        public override string getImage()
        {
            return thisImage;
        }

        public override string Play(Player p)
        {
            if (p.getCurrentRoom() == 19)
            {
                p.addIChip(3);
                return (p.getPlayerName() + " played PHIL 270 Class for 3 Integrity Chip");
            }
            return (p.getPlayerName() + " played " + thisImage + " FAILED");
        }
    }
}
