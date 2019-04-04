using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catan_Asp._Net.Controllers.CreateHexagons
{
    public class Docks
    {
        int randomDock;
        string trade;
        int woodDock = 1;
        int stoneDock = 1;
        int sheepDock = 1;
        int grainDock = 1;
        int oreDock = 1;
        int generalDock = 4;

        public List<int> Harborhexes()
        {
            int[] harborhexes = new int[] { 0, 2, 8, 9, 21, 22, 32, 33, 35 };
            List<int> HarborPositions = new List<int>();
            HarborPositions.AddRange(harborhexes);

            return HarborPositions;
        }

        public string DockType()
        {
            Random random = new Random();
            randomDock = random.Next(1, 7);

            switch(randomDock)
            {
                case 1:
                if (woodDock < 1) { randomDock = 1; goto case 2; }
                if (woodDock == 1) { trade = "../Images/WoodDock.png"; woodDock--; }
                     break;

                case 2:
                if (stoneDock < 1) { randomDock = 2; goto case 3; }
                if (stoneDock == 1) { trade = "../Images/StoneDock.png"; stoneDock--; }
                    break;

                case 3:
                if (sheepDock < 1) { randomDock = 3; goto case 4; }
                if (sheepDock == 1) { trade = "../Images/SheepDock.png"; sheepDock--; }
                    break;

                case 4:
                if (grainDock < 1) { randomDock = 4; goto case 5; }
                if (grainDock == 1) { trade = "../Images/GrainDock.png"; grainDock--; }
                    break;

                case 5:
                if (oreDock < 1) { randomDock = 5; goto case 6; }
                if (oreDock == 1) { trade = "../Images/OreDock.png"; oreDock--; }
                    break;

                case 6:
                if (generalDock == 0) { randomDock = 6; goto case 1; }
                if (generalDock > 0) { trade = "../Images/GeneralDock.png"; generalDock--; }
                    break;
            }
            return trade;
        }
    }
}