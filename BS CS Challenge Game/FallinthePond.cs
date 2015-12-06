using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class FallinthePond : CardInterface
    {
        string thisImage;
        public FallinthePond()
        {
            thisImage = "Fall in the Pond";
        }

        public override string Play(Player p)
        {

            if (p.getCurrentRoom() == 1 && p.getLChip() > 2)
            {
                p.addIChip(1);
                p.addCChip(1);
                return (p.getPlayerName() + " played " + thisImage + " for 1 integrity chip and 1 craft chip");
            }
            p.setCurrentRoom(20);
            p.addQPoint(-2);
            return (p.getPlayerName() + " played " + thisImage + " FAILED");

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
            return (p.getCurrentRoom() == 1 && p.getLChip() > 2);
        }
    }
}
