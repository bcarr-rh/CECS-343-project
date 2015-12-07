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

        public override bool Check(Player p)
        {
            return (p.getCurrentRoom() == 8 && p.getCChip() == 6);
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
            if (p.getCurrentRoom() == 8 && p.getCChip() == 6)
            {
                p.addQPoint(6);
                return (p.getPlayerName() + " played ENGL 317 Class for 6 Quality Points");
            }
            p.setCurrentRoom(2);
            return (p.getPlayerName() + " played " + thisImage + " FAILED");
        }
    }
}
