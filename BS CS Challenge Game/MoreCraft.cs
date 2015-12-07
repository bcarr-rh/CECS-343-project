﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class MoreCraft : CardInterface
    {
        private string thisImage;

        public MoreCraft()
        {
            thisImage = "MoreCraft";
        }

        public override string getImage()
        {
            return thisImage;
        }

        public override string Play(Player p)
        {
            p.addCChip(10);
            return (p.getPlayerName() + " played More Craft Card for 10 Craft chips");  
        }
    }
}