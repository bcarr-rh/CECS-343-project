﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class LateforClass : CardInterface
    {
        string thisImage;
        public LateforClass()
        {
            thisImage = "Late for Class";
        }

        public override string Play(Player p)
        {

            if (p.getCurrentRoom() != 6 && p.getCurrentRoom() < 11)
            {
                p.addCChip(1);
                p.setCurrentRoom(19);
                return (p.getPlayerName() + " played " + thisImage + " for 1 craft chip");
            }
            return (p.getPlayerName() + " played " + thisImage + " FAILED");

        }
        public override string getImage()
        {
            return thisImage;
        }
    }
}
