using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class CECS277 : CardInterface
    {
        private string thisImage;

        public CECS277()
        {
            thisImage = "CECS277";
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
                return (p.getPlayerName() + " played CECS 277 Class for 5 Quality Points");
            }
            p.addQPoint(-2);
            p.discardPick();
            return (p.getPlayerName() + " played " + thisImage + " FAILED");
        }
    }
}
