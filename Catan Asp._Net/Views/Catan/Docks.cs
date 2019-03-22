using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catan_Asp._Net.Views.Catan
{
    public class Docks
    {
        Random random = new Random();
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
            dockPattern = random.Next(1, 3);
            return dockPattern;
        }

        public string DockType()
        {
            randomDock = random.Next(1, 7);

            if (randomDock == 1 && woodDock != 0) { randomDock++; }
            if (randomDock == 2 && stoneDock != 0) { randomDock++; }
            if (randomDock == 3 && sheepDock != 0) { randomDock++; }
            if (randomDock == 4 && grainDock != 0) { randomDock++; }
            if (randomDock == 5 && oreDock != 0) { randomDock++; }
            if (randomDock == 6 && generalDock >= 4) { randomDock = 1; }

            if (randomDock == 1 && woodDock == 0) { trade = "../Images/WoodDock.png"; woodDock++; }
            if (randomDock == 2 && stoneDock == 0) { trade = "../Images/StoneDock.png"; stoneDock++; }
            if (randomDock == 3 && sheepDock == 0) { trade = "../Images/SheepDock.png"; sheepDock++; }
            if (randomDock == 4 && grainDock == 0) { trade = "../Images/GrainDock.png"; grainDock++; }
            if (randomDock == 5 && oreDock == 0) { trade = "../Images/OreDock.png"; oreDock++; }
            if (randomDock == 6 && generalDock < 4) { trade = "../Images/GeneralDock.png"; generalDock++; }

            return trade;
        }
    }
}