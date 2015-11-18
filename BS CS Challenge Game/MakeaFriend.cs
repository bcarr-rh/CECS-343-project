using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class MakeaFriend : CardInterface
    {
        string thisImage;
        public MakeaFriend()
        {
            thisImage = "Make a Friend";
        }

        public override string Play(Player p)
        {

            if ((p.getCurrentRoom() == 12 || p.getCurrentRoom() == 15) && p.getIChip() > 1)
            {
                p.addQPoint(3);
                choseChip chose = new choseChip(1, 1, 1, p);
                p.addChipChosen(chose.getChoice());
                return (p.getPlayerName() + " played " + thisImage + " for 3 Quality Points" + chose.getChoice());
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
