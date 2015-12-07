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
                p.addIChip(2);
                return (p.getPlayerName() + " played CECS 201 Class for 2 Integrity chip");
            }
            return (p.getPlayerName() + " played " + thisImage + " FAILED");
        }
    }
}
