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
        LinkedList<CardInterface> hand;
        int currentRoom;
        int lChip;
        int cChip;
        int iChip;
        int qPoint;

        int incCard;
        int disCard;


        public Player(String name, int room)
        {
            playerName = name;
            currentRoom = room;
            lChip = 6;
            cChip = 6;
            iChip = 6;
            qPoint = 6;
            incCard = 0;
            disCard = 0;
            hand = new LinkedList<CardInterface>();

        }
        public CardInterface getCard(CardInterface c)
        {
            hand.AddLast(c);
            CardInterface temp = hand.First();
            hand.RemoveFirst();
            return temp;

        }

        public CardInterface getNextCard()
        {
            CardInterface temp = hand.First();
            hand.RemoveFirst();
            return temp;
        }

        public int getIncCard()
        {
            return incCard;
        }
        public void incCardmm()
        {
            incCard--;
        }

        public int getDisCard()
        {
            return disCard;
        }

        public void disCardmm()
        {
            disCard--;
        }
        public void addCard(CardInterface c)
        {
            hand.AddFirst(c);
        }

        public int handSize()
        {
            return hand.Count + 1;
        }
        //TODO DRAW CARD
        public void addExtraCard()
        {
            //hand.AddFirst(null);
            incCard++;
        }
        //TODO pick card to discard?
        public void discardPick()
        {
            disCard++;
        }

        //public CardInterface discard()
        //{
        //    CardInterface c = hand.Last();
        //    hand.RemoveLast();
        //    return c;
        //}


        public int getLChip()
        {
            return lChip;
        }
        public int getCChip()
        {
            return cChip;
        }
        public int getIChip()
        {
            return iChip;
        }
        public int getQPoint()
        {
            return qPoint;
        }

        public void addChipChosen(string choice)
        {
            if(choice.Equals("1 Learning Chip"))
            {
                lChip++;
            }
            else if(choice.Equals("1 Integrity Chip"))
            {
                iChip++;
            }
            else if(choice.Equals("1 Craft Chip"))
            {
                cChip++;
            }
        }

        public void addLChip(int x)
        {
            lChip += x;
        }
        public void addCChip(int x)
        {
            cChip += x;
        }
        public void addIChip(int x)
        {
            iChip += x;
        }
        public void addQPoint(int x)
        {
            qPoint += x;
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
