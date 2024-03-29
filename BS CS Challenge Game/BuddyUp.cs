﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class BuddyUp : CardInterface
    {
        string thisImage;
        public BuddyUp()
        {
            thisImage = "Buddy Up";
        }

        public override string Play(Player p)
        {

            if (p.getCurrentRoom() == 18 || p.getCurrentRoom() == 0)
            {
                choseChip chose = new choseChip(1, 1, 0, p);
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
