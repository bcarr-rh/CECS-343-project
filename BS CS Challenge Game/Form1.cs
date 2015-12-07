using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BS_CS_Challenge_Game
{
    public partial class Form1 : Form
    {
        
        private Room[] roomArray;
        private Player[] playerArray;
        private List<CardInterface> deck;
        private List<CardInterface> discardDeck;
        private int moveCount;
        private CardInterface showCard;
        private bool SophmoreCheck;
        private readonly int MOVELIMIT = 3;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SophmoreCheck = false;
            MoveButton.Enabled = false;
            deck =  new List<CardInterface>();
            discardDeck =  new List<CardInterface>();
            roomArray = new Room[21];
            playerArray = new Player[3];
            
            if (Screen.PrimaryScreen.Bounds.Width > 1670)
                this.Width = 1670;
            else
                this.Width = Screen.PrimaryScreen.Bounds.Width;
            if (Screen.PrimaryScreen.Bounds.Height > 2100)
                this.Height = 2000;
            else 
                this.Height = Screen.PrimaryScreen.Bounds.Height - 100;
            
            this.splitContainer1.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 3;
            this.splitContainer1.Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height / 3;
            playerArray[0] = new Player("John", 17);
            playerArray[1] = new Player("Kyle", 17);
            playerArray[2] = new Player("Martha", 17);
            playerArray[0].addLChip(2);
            playerArray[0].addCChip(2);
            playerArray[0].addIChip(2);
            playerArray[1].addLChip(3);
            playerArray[1].addCChip(1);
            playerArray[1].addIChip(2);
            playerArray[2].addLChip(0);
            playerArray[2].addCChip(3);
            playerArray[2].addIChip(3);
            Random rnd = new Random();
            // shuffle player array
            int n = playerArray.Length;
            while (n > 1)
            {
                int k = rnd.Next(n--);
                Player temp = playerArray[n];
                playerArray[n] = playerArray[k];
                playerArray[k] = temp;
            }


            roomArray[0] = new Room("George Allen Field",0, button1, button2, button3);
            roomArray[1] = new Room("Japanese Garden",1, button6, button5, button4);
            roomArray[2] = new Room("Student Parking",2, button9, button8, button7);
            roomArray[3] = new Room("Pyramid",3, button12, button11, button10);
            roomArray[5] = new Room("Rec Center",5, button15, button14, button13);
            roomArray[6] = new Room("Forbidden Parking",6, button18, button17, button16);
            roomArray[4] = new Room("West Walkway",4, button63, button62, button61);
            roomArray[10] = new Room("East Walkway",10, button51, button50, button49);
            roomArray[11] = new Room("Computer Lab",11, button21, button20, button19);
            roomArray[14] = new Room("ECS 302",14, button24, button23, button22);
            roomArray[18] = new Room("Eat Club",18, button27, button26, button25);
            roomArray[19] = new Room("Conference Room",19, button30, button29, button28);
            roomArray[12] = new Room("North Hall",12, button33, button32, button31);
            roomArray[15] = new Room("South Hall",15, button36, button35, button34);
            roomArray[13] = new Room("Room Of Retirement",13, button39, button38, button37);
            roomArray[16] = new Room("Elevators",16, button42, button41, button40);
            roomArray[17] = new Room("ECS 308",17, button45, button44, button43);
            roomArray[20] = new Room("Lactation Lounge",20, button48, button47, button46);
            roomArray[7] = new Room("Library",7, button54, button53, button52);
            roomArray[8] = new Room("LA 5",8, button57, button56, button55);
            roomArray[9] = new Room("Bratwurst Hall",9, button60, button59, button58);
            roomArray[0].addNextTo(1);
            roomArray[0].addNextTo(3);
            roomArray[0].addNextTo(5);
            roomArray[0].addNextTo(4);
            roomArray[1].addNextTo(0);
            roomArray[1].addNextTo(3);
            roomArray[1].addNextTo(2);
            roomArray[2].addNextTo(1);
            roomArray[2].addNextTo(3);
            roomArray[2].addNextTo(5);
            roomArray[2].addNextTo(6);
            roomArray[3].addNextTo(0);
            roomArray[3].addNextTo(1);
            roomArray[3].addNextTo(2);
            roomArray[3].addNextTo(5);
            roomArray[4].addNextTo(0);
            roomArray[4].addNextTo(5);
            roomArray[4].addNextTo(12);
            roomArray[4].addNextTo(7);
            roomArray[5].addNextTo(0);
            roomArray[5].addNextTo(3);
            roomArray[5].addNextTo(2);
            roomArray[5].addNextTo(6);
            roomArray[5].addNextTo(4);
            roomArray[6].addNextTo(2);
            roomArray[6].addNextTo(5);
            roomArray[6].addNextTo(10);
            roomArray[7].addNextTo(4);
            roomArray[7].addNextTo(8);
            roomArray[8].addNextTo(7);
            roomArray[8].addNextTo(16);
            roomArray[8].addNextTo(9);
            roomArray[9].addNextTo(8);
            roomArray[9].addNextTo(10);
            roomArray[10].addNextTo(6);
            roomArray[10].addNextTo(9);
            roomArray[10].addNextTo(15);
            roomArray[11].addNextTo(12);
            roomArray[12].addNextTo(4);
            roomArray[12].addNextTo(11);
            roomArray[12].addNextTo(14);
            roomArray[12].addNextTo(15);
            roomArray[12].addNextTo(16);
            roomArray[12].addNextTo(13);
            roomArray[14].addNextTo(15);
            roomArray[14].addNextTo(12);
            roomArray[15].addNextTo(12);
            roomArray[15].addNextTo(14);
            roomArray[15].addNextTo(18);
            roomArray[15].addNextTo(19);
            roomArray[15].addNextTo(10);
            roomArray[15].addNextTo(20);
            roomArray[15].addNextTo(17);
            roomArray[16].addNextTo(12);
            roomArray[16].addNextTo(8);
            roomArray[17].addNextTo(15);
            roomArray[18].addNextTo(15);
            roomArray[19].addNextTo(15);
            roomArray[20].addNextTo(15);
            deck.Add(new EnjoyingNature());
            deck.Add(new EnjoyingThePeace());
            deck.Add(new ANewLaptop());
            deck.Add(new BuddyUp());
            deck.Add(new CECS100());
            deck.Add(new CECS105());
            deck.Add(new CECS174());
            deck.Add(new CHEM111());
            deck.Add(new ChoosingaMajor());
            deck.Add(new ElectiveClass());
            deck.Add(new ExcercisingMindandBody());
            deck.Add(new FallinthePond());
            deck.Add(new FindingtheLab());
            deck.Add(new GoodbyeProfessor());
            deck.Add(new LateforClass());
            deck.Add(new LearningLinux());
            deck.Add(new LearningNetbeans());
            deck.Add(new LearningtheRulesofSoccer());
            deck.Add(new LoudBuzzing());
            deck.Add(new LunchatBratwurstHall());
            deck.Add(new MakeaFriend());
            deck.Add(new MaketheDeansList());
            deck.Add(new Math122());
            deck.Add(new Math123());
            deck.Add(new MeettheDean());
            deck.Add(new OralCommunication());
            deck.Add(new ParkingViolation());
            deck.Add(new PassSoccerClass());
            deck.Add(new Physics151());
            deck.Add(new PresstheRightFloor());
            deck.Add(new ProfessorEnglert());
            deck.Add(new ProfessorHoffman());
            deck.Add(new ProgramCrashes());
            deck.Add(new ResearchCompilers());
            deck.Add(new ScoreaGoal());
            deck.Add(new SoccerGoalie());
            deck.Add(new StudentParking());
            deck.Add(new TheBigGame());
            deck.Add(new TheOutpost());
            Shuffle();
            PlayCardButton.Enabled = false;
            moveCount = 0;
            
            for (int i = 0; i < 5; i++)
            {
                playerArray[0].addCard(deck[deck.Count - 1]);
                deck.RemoveAt(deck.Count - 1);
            }
            //playerArray[0].addCard(deck[20]); problems with make a friend card
            showCard = deck[deck.Count - 1];
            deck.RemoveAt(deck.Count - 1);
            pictureBox2.ImageLocation = "C:\\Users\\adoni\\Documents\\Visual Studio 2015\\Projects\\CECS-343-project\\BS CS Challenge Game\\Resources\\" + showCard.getImage() + ".JPG";
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            roomsList.Items.Clear();
            foreach (int s in roomArray[playerArray[0].getCurrentRoom()].getNextTo())
            {
                roomsList.Items.Add(roomArray[s].getRoomName());
            }
            roomArray[playerArray[0].getCurrentRoom()].MoveTo(playerArray[0].getPlayerName());
            roomArray[playerArray[1].getCurrentRoom()].MoveTo(playerArray[1].getPlayerName());
            roomArray[playerArray[2].getCurrentRoom()].MoveTo(playerArray[2].getPlayerName());
            PlayerIndicator.Text = "Human player is " + playerArray[0].getPlayerName();

            playerArray[0].setAi(false);
            playerArray[1].setAi(true);
            playerArray[2].setAi(true);

            updatePointsDisplay();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void room()
        {

        }

        private void button64_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            
            roomsList.Items.Clear();
            foreach (int s in roomArray[playerArray[0].getCurrentRoom()].getNextTo())
            {
                roomsList.Items.Add(roomArray[s].getRoomName());
            }
            roomArray[playerArray[0].getCurrentRoom()].MoveTo(playerArray[0].getPlayerName());
            roomArray[playerArray[1].getCurrentRoom()].MoveTo(playerArray[1].getPlayerName());
            roomArray[playerArray[2].getCurrentRoom()].MoveTo(playerArray[2].getPlayerName());
            PlayerIndicator.Text = "Human player is " + playerArray[0].getPlayerName();
        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint_1(object sender, PaintEventArgs e)
        {
         
        }

        private void splitContainer1_Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        // DRAW CARD BUTTON
        private void DrawCard_Click(object sender, EventArgs e)
        {
            DrawCard.Enabled = false;
            MoveButton.Enabled = true;
            if (deck.Count == 0)
            {
                for (int i = 0; discardDeck.Count != 0;i++)
                {
                    deck[i] = discardDeck[discardDeck.Count - 1];
                    discardDeck.RemoveAt(discardDeck.Count - 1);
                }
                Shuffle();
            }
            CardInterface temp = deck[deck.Count - 1];
            playerArray[0].addCard(temp);
            deck.RemoveAt(deck.Count - 1);
            PlayCardButton.Enabled = true;
            

        }

        private void MoveButton_Click(object sender, EventArgs e)
        {
            moveCount++;
            try {
                String Room = roomsList.SelectedItem.ToString();
                foreach (int s in roomArray[playerArray[0].getCurrentRoom()].getNextTo())
                {
                    if (roomArray[s].getRoomName().Equals(Room))
                    {
                        roomArray[playerArray[0].getCurrentRoom()].MoveOut(playerArray[0].getPlayerName());
                        playerArray[0].setCurrentRoom(roomArray[s].getRoomNum());
                        roomArray[s].MoveTo(playerArray[0].getPlayerName());
                        break;
                    }

                }
            }
            catch(NullReferenceException) {
                MessageBox.Show("Select a room to move to");
            }
            //AI LOGIC
            Random rnd = new Random();
            //AI One
            for (int i = 0; i < 3; i++)
            {
                roomArray[playerArray[1].getCurrentRoom()].MoveOut(playerArray[1].getPlayerName());
                int ai1RndSize = roomArray[playerArray[1].getCurrentRoom()].getNextTo().Count() - 1;
                int ai1 = roomArray[playerArray[1].getCurrentRoom()].getNextTo()[rnd.Next(0, ai1RndSize)];
                playerArray[1].setCurrentRoom(roomArray[ai1].getRoomNum());
                roomArray[ai1].MoveTo(playerArray[1].getPlayerName());
            }
            //AI two
            for (int i = 0; i < 3; i++)
            {
                roomArray[playerArray[2].getCurrentRoom()].MoveOut(playerArray[2].getPlayerName());
                int ai2RndSize = roomArray[playerArray[2].getCurrentRoom()].getNextTo().Count() - 1;
                int ai2 = roomArray[playerArray[2].getCurrentRoom()].getNextTo()[rnd.Next(0, ai2RndSize)];
                playerArray[2].setCurrentRoom(roomArray[ai2].getRoomNum());
                roomArray[ai2].MoveTo(playerArray[2].getPlayerName());
            }
            //reset roomsList
            roomsList.Items.Clear();
            foreach (int s in roomArray[playerArray[0].getCurrentRoom()].getNextTo())
            {
                roomsList.Items.Add(roomArray[s].getRoomName());
            }

            if (moveCount >= MOVELIMIT)
            {
                MoveButton.Enabled = false;
            }
            updatePointsDisplay();

            MoveButton.Enabled = false;
        }

        private void roomsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (moveCount < 3 && !DrawCard.Enabled)
            {
                MoveButton.Enabled = true;
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {

        }

        private void button40_Click(object sender, EventArgs e)
        {

        }

        private void button42_Click(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {


            //String Room = roomsList.SelectedItem.ToString();
           // playerArray[0];

        }

        public  void Shuffle()
        {
            Random rng = new Random();
            int n = deck.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                CardInterface value = deck[k];
                deck[k] = deck[n];
                deck[n] = value;
            }
        }
        //show next card
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            showCard = playerArray[0].getCard(showCard);
            pictureBox2.ImageLocation = "C:\\Users\\adoni\\Documents\\Visual Studio 2015\\Projects\\CECS-343-project\\BS CS Challenge Game\\Resources\\" + showCard.getImage() + ".JPG";

        }
        //DONE: TODO if QP % 15 == 0 get a chip of choice.
        //DONE: TODO Add AI Move and Play. 
        //TODO  Monitor total QP for all players and if > 60 discard cards and add new ones.
        //DONE: TODO Before reset of cards discard human players hand and draw 5 of the new cards.
        //DONE: TODO fix the move after card is done.
        private void PlayCardButton_Click(object sender, EventArgs e)
        {
            moveCount = 0; //RESET MOVES
            MoveButton.Enabled = false;
            PlayCardButton.Enabled = false;
            DrawCard.Enabled = true;
            PlayerIndicator.Lines = new string[] { showCard.Play(playerArray[0]) };
            // if QP % 15 == 0 get a chip of choice.
            if (playerArray[0].getQPoint() % 15 == 0)
            {
                choseChipForm chose = new choseChipForm(1, 1, 1, playerArray[0]);
            }
            //discard cards
            while (playerArray[0].getDisCard() > 0)
            {
                PopupForm popup = new PopupForm();
                //PictureBox discardPic = new PictureBox();
                //popup.Controls.Add(discardPic);
                popup.setHand(showCard, playerArray[0]);
                DialogResult dg = popup.ShowDialog();
                showCard = (CardInterface)popup.getCard();
                discardDeck.Add(showCard);
                showCard = playerArray[0].getNextCard();
                playerArray[0].disCardmm();
            }

            //shuffle deck if empty
            while (playerArray[0].getIncCard() > 0)
            {
                if (deck.Count == 0)
                {
                    for (int i = 0; discardDeck.Count != 0; i++)
                    {
                        deck[i] = discardDeck[discardDeck.Count - 1];
                        discardDeck.RemoveAt(discardDeck.Count - 1);
                    }
                    Shuffle();
                }
                CardInterface temp = deck[deck.Count - 1];
                playerArray[0].addCard(temp);
                deck.RemoveAt(deck.Count - 1);
            }

            //discard played card and get another from players hand.
            discardDeck.Add(showCard);
            showCard = playerArray[0].getNextCard();
            updatePointsDisplay();

            //discard if hand bigger then 7
            while( playerArray[0].handSize() > 7)
            {
                playerArray[0].discardPick();
            }

            while (playerArray[0].getDisCard() > 0)
            {
                PopupForm popup = new PopupForm();
                //PictureBox discardPic = new PictureBox();
                //popup.Controls.Add(discardPic);
                popup.setHand(showCard, playerArray[0]);
                DialogResult dg = popup.ShowDialog();
                showCard = (CardInterface)popup.getCard();
                discardDeck.Add(showCard);
                showCard = playerArray[0].getNextCard();
                playerArray[0].disCardmm();
            }
            if (!SophmoreCheck && playerArray[0].getQPoint() + playerArray[1].getQPoint() + playerArray[2].getQPoint() > 60)
            {
                SophmoreCheck = true;
                for (int i = 0; discardDeck.Count != 0; i++)
                {
                    deck.Add(discardDeck[discardDeck.Count - 1]);
                    discardDeck.RemoveAt(discardDeck.Count - 1);
                }
                deck.Add(showCard);
                while(playerArray[0].handSize() > 0)
                {
                    deck.Add(playerArray[0].getNextCard());
                }
                foreach(CardInterface c in deck)
                {
                    if (c.DicardThisCard())
                    {
                        deck.Remove(c);
                    }
                }
                //TODO
                //ADD ALL NEW CARDS TO DECK HERE FOR SOPHMORE
                deck.Add(new CECS201());
                deck.Add(new CECS228());
                deck.Add(new CECS274());
                deck.Add(new CECS277());
                deck.Add(new CECS282());
                deck.Add(new ENGL317());
                deck.Add(new PHIL270());
                deck.Add(new PHYS152());
                deck.Add(new MoreCraft());
                deck.Add(new MoreIntegrity());
                deck.Add(new MoreLearning());
                for (int i = 0; i < 5; i++)
                {
                    playerArray[0].addCard(deck[deck.Count - 1]);
                    deck.RemoveAt(deck.Count - 1);
                }

                showCard = deck[deck.Count - 1];
                deck.RemoveAt(deck.Count - 1);
            }
            Random rnd = new Random();
            //AI One
            for (int i = 0; i < 3; i++)
            {
                foreach (CardInterface c in deck)
                {
                    if (c.Check(playerArray[1]))
                    {
                        PlayerIndicator.Lines = new string[] { c.Play(playerArray[1]) };
                        i = 3;
                        break;
                    }
                }
            }
            //AI two
            for (int i = 0; i < 3; i++)
            { 
                foreach (CardInterface c in deck)
                {
                    if (c.Check(playerArray[2]))
                    {
                        PlayerIndicator.Lines = new string[] { c.Play(playerArray[2]) };
                        discardDeck.Add(c);
                        deck.Remove(c);
                        i = 3;
                        break;
                    }
                }
            }
            //TODOfix the move after card is done.
            //teleport after play card fix
            roomArray[playerArray[0].lastRoom].MoveOut(playerArray[0].getPlayerName());
            roomArray[playerArray[0].getCurrentRoom()].MoveTo(playerArray[0].getPlayerName());

            updatePointsDisplay();
        }



        private void updatePointsDisplay()
        {
            pictureBox2.ImageLocation = "C:\\Users\\adoni\\Documents\\Visual Studio 2015\\Projects\\CECS-343-project\\BS CS Challenge Game\\Resources\\" + showCard.getImage() + ".JPG";
            string[] lines = new string[6];
            lines[0] = playerArray[0].getPlayerName() + " Learning: " + playerArray[0].getLChip() + " Craft: " + playerArray[0].getCChip() + " Integrity: " + playerArray[0].getIChip() + " Quality: " + playerArray[0].getQPoint();
            lines[1] = playerArray[1].getPlayerName() + " Learning: " + playerArray[1].getLChip() + " Craft: " + playerArray[1].getCChip() + " Integrity: " + playerArray[1].getIChip() + " Quality: " + playerArray[1].getQPoint();
            lines[2] = playerArray[2].getPlayerName() + " Learning: " + playerArray[2].getLChip() + " Craft: " + playerArray[2].getCChip() + " Integrity: " + playerArray[2].getIChip() + " Quality: " + playerArray[2].getQPoint();
            lines[3] = "Cards in Deck: " + deck.Count;
            lines[4] = "Discards out of play: " + discardDeck.Count;
            lines[5] = playerArray[0].getPlayerName() + " is in " + roomArray[playerArray[0].getCurrentRoom()].getRoomName();
            PointsDisplay.Lines = lines;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
