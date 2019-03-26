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
                if (woodDock != 0) { goto case 2; }
                if (woodDock == 0) { trade = "../Images/WoodDock.png"; woodDock++; }
                     break;

                case 2:
                if (stoneDock != 0) { goto case 3; }
                if (stoneDock == 0) { trade = "../Images/StoneDock.png"; stoneDock++; }
                    break;

                case 3:
                if (sheepDock != 0) { goto case 4; }
                if (sheepDock == 0) { trade = "../Images/SheepDock.png"; sheepDock++; }
                    break;

                case 4:
                if (grainDock != 0){ goto case 5; }
                if (grainDock == 0) { trade = "../Images/GrainDock.png"; grainDock++; }
                    break;

                case 5:
                if (oreDock != 0) { goto case 6; }
                if (oreDock == 0) { trade = "../Images/OreDock.png"; oreDock++; }
                    break;

                case 6:
                if (generalDock >= 4) { goto case 1; }
                if (generalDock < 4) { trade = "../Images/GeneralDock.png"; generalDock++; }
                    break;
            }

            return trade;
        }

        public List<int> DockPatternPositions(int i, int dockRandom)
        {
            List<int> positions = new List<int>();
            if (dockRandom == 1 && (i == 0 || i == 2 || i == 8 || i == 9 || i == 21 || i == 22 || i == 32 || i == 33 || i == 35))
            {
                positions.Add(i);
            }
            else if (dockRandom == 2 && (i == 1 || i == 3 || i == 4 || i == 14 || i == 15 || i == 27 || i == 28 || i == 34 || i == 36))
            {
                positions.Add(i);
            }
            return positions;
        }
    }
}