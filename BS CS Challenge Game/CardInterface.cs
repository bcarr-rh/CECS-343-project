using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    abstract class CardInterface
    {
        public CardInterface()
        {

        }

        abstract public string Play(Player p);
        abstract public string getImage();
    }
}
