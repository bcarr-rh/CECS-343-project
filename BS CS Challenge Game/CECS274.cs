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
            return ((p.getCurrentRoom() == 17 || p.getCurrentRoom() == 14
                || p.getCurrentRoom() == 11) && p.getLChip() >= 7);
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
            if ((p.getCurrentRoom() == 17 || p.getCurrentRoom() == 14
                || p.getCurrentRoom() == 11) && p.getLChip() >= 7)
            {
                p.addQPoint(5);
                p.addExtraCard();
                return (p.getPlayerName() + " played CECS 274 Card for 5 Quality Points and 1 Game Card");
            }
            p.addQPoint(-3);
            return (p.getPlayerName() + " played " + thisImage + " FAILED");
        }
    }
}
