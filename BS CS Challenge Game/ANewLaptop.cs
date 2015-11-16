using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class ANewLaptop : CardInterface
    {
        string thisImage;
        public ANewLaptop()
        {
            thisImage = "A New Laptop";
        }

        public override string Play(Player p)
        {

            if (p.getCurrentRoom() == 11 && p.getIChip() > 3)
            {
                p.addQPoint(3);
                choseChip chose = new choseChip(1, 1, 1, p);
                return (p.getPlayerName() + " played " + thisImage + " for 3 Quality Points and " + chose.getChoice());
            }
            p.discardPick();
            return (p.getPlayerName() + " played " + thisImage + " FAILED");

        }
        public override string getImage()
        {
            return thisImage;
        }
    }
}
