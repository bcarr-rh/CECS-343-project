using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class CECS282 : CardInterface
    {
        private string thisImage;

        public CECS282()
        {
            thisImage = "CECS282";
        }

        public override bool Check(Player p)
        {
            return ((p.getCurrentRoom() > 9 && p.getCurrentRoom() < 21) && (p.getCChip() >= 8 && p.getIChip() >= 8 && p.getLChip() >= 8));
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
            if ((p.getCurrentRoom() > 9 && p.getCurrentRoom() < 21) && (p.getCChip() >= 8 && p.getIChip() >= 8 && p.getLChip() >= 8))
            {
                p.addQPoint(5);
                return (p.getPlayerName() + " played CECS 282 Class for 5 Quality Points");
            }
            p.addQPoint(-2);
            p.discardPick();
            return (p.getPlayerName() + " played " + thisImage + " FAILED");
        }
    }
}
