using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class OralCommunication : CardInterface
    {
        string thisImage;
        public OralCommunication()
        {
            thisImage = "Oral Communication";
        }

        public override string Play(Player p)
        {

            if (p.getCurrentRoom() < 11 && p.getIChip() > 3)
            {
                p.addQPoint(4);
                choseChip chose = new choseChip(1, 1, 1, p);
                p.addChipChosen(chose.getChoice());
                return (p.getPlayerName() + " played " + thisImage + " for 4 Quality Points and " + chose.getChoice());
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
