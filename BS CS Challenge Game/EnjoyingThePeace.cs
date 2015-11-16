using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class EnjoyingThePeace : CardInterface
    {
        string thisImage;
        public EnjoyingThePeace()
        {
            thisImage = "Enjoying the Peace";
        }

        public override string Play(Player p)
        {

            if (p.getCurrentRoom() == 1)
            {
                choseChip chose = new choseChip(1, 0, 1, p);
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
