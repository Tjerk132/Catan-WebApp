using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catan_Asp._Net.Views.Catan
{
    public class Docks
    {
        int dockPattern;
        int randomDock;
        string trade;
        int woodDock = 0;
        int stoneDock = 0;
        int sheepDock = 0;
        int grainDock = 0;
        int oreDock = 0;
        int generalDock = 0;

        public int DockPattern()
        {
            Random random = new Random();
            dockPattern = random.Next(1, 3);
            return dockPattern;
        }

        public string DockType()
        {
            Random random = new Random();
            randomDock = random.Next(1, 7);

            switch(randomDock)
            {
                case 1:
                if (woodDock != 0)
                { randomDock++; }
                if (woodDock == 0)
                { trade = "../Images/WoodDock.png"; woodDock++; }
                     break;

                case 2:
                if (stoneDock != 0)
                { randomDock++; }
                if (stoneDock == 0)
                { trade = "../Images/StoneDock.png"; stoneDock++; }
                    break;

                case 3:
                if (sheepDock != 0)
                { randomDock++; }
                if (sheepDock == 0)
                { trade = "../Images/SheepDock.png"; sheepDock++; }
                    break;

                case 4:
                if (grainDock != 0)
                { randomDock++; }
                if (grainDock == 0)
                { trade = "../Images/GrainDock.png"; grainDock++; }
                    break;

                case 5:
                if (oreDock != 0)
                { randomDock++; }
                if (oreDock == 0)
                { trade = "../Images/OreDock.png"; oreDock++; }
                    break;

                case 6:
                if (generalDock > 0)
                { randomDock = 1; }
                if (generalDock == 0)
                { trade = "../Images/GeneralDock.png"; generalDock++; }
                    break;
            }

            return trade;
        }

        public List<int> DockPatternPositions(int i, int dockRandom)
        {
            List<int> positions = new List<int>();
            if (dockRandom == 1 && (i == 0 || i == 2 || i == 8 || i == 9 || i == 21 || i == 22 || i == 32 || i == 33 || i == 35))
            {
                positions.Add(0);
                positions.Add(2);
                positions.Add(8);
                positions.Add(9);
                positions.Add(21);
                positions.Add(22);
                positions.Add(32);
                positions.Add(33);
                positions.Add(35);
            }
            else if (dockRandom == 2 && (i == 1 || i == 3 || i == 4 || i == 14 || i == 15 || i == 27 || i == 28 || i == 34 || i == 36))
            {
                positions.Add(1);
                positions.Add(3);
                positions.Add(4);
                positions.Add(14);
                positions.Add(15);
                positions.Add(27);
                positions.Add(28);
                positions.Add(34);
                positions.Add(36);
            }
            return positions;
        }
    }
}