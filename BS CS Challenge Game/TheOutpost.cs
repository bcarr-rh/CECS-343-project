using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class TheOutpost : CardInterface
    {
        string thisImage;
        public TheOutpost()
        {
            thisImage = "The Outpost";
        }

        public override string Play(Player p)
        {

            if (p.getCurrentRoom() < 10 && p.getCurrentRoom() != 6)
            {
                choseChip chose = new choseChip(1, 1, 1, p);
                p.addChipChosen(chose.getChoice());
                return (p.getPlayerName() + " played " + thisImage + " for " + chose.getChoice());
            }
            return (p.getPlayerName() + " played " + thisImage + " FAILED");

        }
        public override string getImage()
        {
            return thisImage;
        }
    }
}
