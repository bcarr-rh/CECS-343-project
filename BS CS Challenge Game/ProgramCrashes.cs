using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_CS_Challenge_Game
{
    class ProgramCrashes : CardInterface
    {
        string thisImage;
        public ProgramCrashes()
        {
            thisImage = "Program Crashes";
        }

        public override string Play(Player p)
        {

            if (p.getCurrentRoom() == 20 && p.getLChip() > 1)
            {
                p.addQPoint(5);
                choseChipForm chose = new choseChipForm(1, 1, 1, p);
                System.Windows.Forms.DialogResult dg = chose.ShowDialog();
                string temp = chose.getChoice();
                return (p.getPlayerName() + " played " + thisImage + " for 5 Quality Points and " + temp);
            }
            p.discardPick();
            p.addQPoint(-2);
            return (p.getPlayerName() + " played " + thisImage + " FAILED");

        }
        public override string getImage()
        {
            return thisImage;
        }
    }
}
