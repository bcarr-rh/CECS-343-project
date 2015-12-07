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

        public override bool Check(Player p)
        {
            return ((p.getCurrentRoom() == 17 || p.getCurrentRoom() == 14
                || p.getCurrentRoom() == 11) && (p.getCChip() == 8 && p.getIChip() == 8 && p.getLChip() == 8));
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
                || p.getCurrentRoom() == 11) && (p.getCChip() >= 8 &&  p.getIChip() >= 8 && p.getLChip() >= 8))
            {
                p.addQPoint(5);
                return (p.getPlayerName() + " played CECS 228 Card for 5 Quality Points");
            }
            p.discardPick();
            p.addQPoint(-2);
            return (p.getPlayerName() + " played " + thisImage + " FAILED");
        }
    }
}
