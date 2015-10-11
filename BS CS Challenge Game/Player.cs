using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class Player
    {
        String playerName;
        int currentRoom;
        public Player(String name)
        {
            playerName = name;
            currentRoom = -1;
        }
        public void setCurrentRoom(int room)
        {
            currentRoom = room;
        }
        public int getCurrentRoom()
        {
            return currentRoom;
        }
        public String getPlayerName()
        {
            return playerName;
        }
    }
}
