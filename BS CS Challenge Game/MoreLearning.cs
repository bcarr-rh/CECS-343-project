using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class MoreLearning : CardInterface
    {
        private string thisImage;

        public MoreLearning()
        {
            thisImage = "MoreLearning";
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
            p.addCChip(10);
            return (p.getPlayerName() + " played More Learning Card for 10 Learning Chips");
        }
    }
}
