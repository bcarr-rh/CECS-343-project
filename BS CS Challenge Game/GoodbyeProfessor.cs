using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class GoodbyeProfessor : CardInterface
    {
        string thisImage;
        public GoodbyeProfessor()
        {
            thisImage = "Goodbye, Professor";
        }

        public override string Play(Player p)
        {

            if (p.getCurrentRoom() == 13 && p.getCChip() > 5 && p.getIChip() > 5 && p.getLChip() > 5)
            {
                p.addQPoint(10);
                return (p.getPlayerName() + " played " + thisImage + " for 10 Quality Points!");
            }
            p.discardPick();
            p.addQPoint(-2);
            return (p.getPlayerName() + " played " + thisImage + " FAILED losing 1 game card");

        }
        public override string getImage()
        {
            return thisImage;
        }
        public override bool DicardThisCard()
        {
            return false;
        }
        public override bool Check(Player p)
        {
            return (p.getCurrentRoom() == 13 && p.getCChip() > 5 && p.getIChip() > 5 && p.getLChip() > 5);
        }
    }
}
