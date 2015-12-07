using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class CECS274 : CardInterface
    {
        private string thisImage;

        public CECS274()
        {
            thisImage = "CECS274";
        }

        public override bool Check(Player p)
        {
            return (p.getCurrentRoom() == 11);
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
            if (p.getCurrentRoom() == 11)
            {
                p.addCChip(6);
                return (p.getPlayerName() + " played CECS 274 Class for 6 Craft Chips");
            }
            return (p.getPlayerName() + " played " + thisImage + " FAILED");
        }
    }
}
