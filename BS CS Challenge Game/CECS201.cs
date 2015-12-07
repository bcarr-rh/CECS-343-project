using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class CECS201 : CardInterface
    {
        private string thisImage;
        
        public CECS201()
        {
            thisImage = "CECS201";
        }

        public override bool Check(Player p)
        {
            return ((p.getCurrentRoom() == 17 || p.getCurrentRoom() == 14
                || p.getCurrentRoom() == 11) && p.getCChip() == 8);
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
                || p.getCurrentRoom() == 11 ) && p.getCChip() >= 8)
            {
                p.addIChip(1);
                p.addCChip(1);
                p.addLChip(1);
                return (p.getPlayerName() + " played CECS 201 Card for 1 Integrity Chip \n1 Craft Chip and 1 Learning Chip" );
            }
            p.discardPick();
            p.addQPoint(-3);
            return (p.getPlayerName() + " played " + thisImage + " FAILED");
        }
    }
}
