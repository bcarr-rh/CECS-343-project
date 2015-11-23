using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class FindingtheLab : CardInterface
    {
        string thisImage;
        public FindingtheLab()
        {
            thisImage = "Finding the Lab";
        }

        public override string Play(Player p)
        {

            if (p.getCurrentRoom() == 16)
            {
                p.addIChip(1);
                return (p.getPlayerName() + " played " + thisImage + " for 1 integrity chip");
            }
            p.addQPoint(-2);
            return (p.getPlayerName() + " played " + thisImage + " FAILED");

        }
        public override string getImage()
        {
            return thisImage;
        }
    }
}
