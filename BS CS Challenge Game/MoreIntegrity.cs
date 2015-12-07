using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class MoreIntegrity : CardInterface
    {
        private string thisImage;

        public MoreIntegrity()
        {
            thisImage = "MoreIntegrity";
        }

        public override bool Check(Player p)
        {
            return true;
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
            p.addIChip(10);
            return (p.getPlayerName() + " played More Integrity Card for 10 Integrity chips");
        }
    }
}
