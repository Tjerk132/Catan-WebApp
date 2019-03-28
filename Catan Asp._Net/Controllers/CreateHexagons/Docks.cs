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
        int woodDock = 0;
        int stoneDock = 0;
        int sheepDock = 0;
        int grainDock = 0;
        int oreDock = 0;
        int generalDock = 0;


        public string DockType()
        {
            Random random = new Random();
            randomDock = random.Next(1, 7);

            switch(randomDock)
            {
                case 1:
                if (woodDock != 0) { randomDock = 1; goto case 2; }
                if (woodDock == 0) { trade = "../Images/WoodDock.png"; woodDock++; }
                     break;

                case 2:
                if (stoneDock != 0) { randomDock = 2; goto case 3; }
                if (stoneDock == 0) { trade = "../Images/StoneDock.png"; stoneDock++; }
                    break;

                case 3:
                if (sheepDock != 0) { randomDock = 3; goto case 4; }
                if (sheepDock == 0) { trade = "../Images/SheepDock.png"; sheepDock++; }
                    break;

                case 4:
                if (grainDock != 0){ randomDock = 4; goto case 5; }
                if (grainDock == 0) { trade = "../Images/GrainDock.png"; grainDock++; }
                    break;

                case 5:
                if (oreDock != 0) { randomDock = 5; goto case 6; }
                if (oreDock == 0) { trade = "../Images/OreDock.png"; oreDock++; }
                    break;

                case 6:
                if (generalDock >= 4) { randomDock = 6; goto case 1; }
                if (generalDock < 4) { trade = "../Images/GeneralDock.png"; generalDock++; }
                    break;
            }
            return trade;
        }
    }
}