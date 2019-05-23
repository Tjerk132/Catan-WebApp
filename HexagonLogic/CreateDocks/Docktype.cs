using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexagonLogic.CreateDocks
{
    class Docktype
    {
        private int randomDock;

        private int woodDock = 1;
        private int stoneDock = 1;
        private int sheepDock = 1;
        private int grainDock = 1;
        private int oreDock = 1;
        //private int generalDock = 4;
        private int generalDock1 = 1;
        private int generalDock2 = 1;
        private int generalDock3 = 1;
        private int generalDock4 = 1;

        public string DockType()
        {
            Random random = new Random();
            randomDock = random.Next(1, 7);

            string HarborKind = "";
            switch (randomDock)
            {
                case 1:
                    if (woodDock < 1) { randomDock = 1; goto case 2; }
                    if (woodDock == 1) { HarborKind = "WoodDock"; woodDock--; }
                    break;

                case 2:
                    if (stoneDock < 1) { randomDock = 2; goto case 3; }
                    if (stoneDock == 1) { HarborKind = "StoneDock"; stoneDock--; }
                    break;

                case 3:
                    if (sheepDock < 1) { randomDock = 3; goto case 4; }
                    if (sheepDock == 1) { HarborKind = "SheepDock"; sheepDock--; }
                    break;

                case 4:
                    if (grainDock < 1) { randomDock = 4; goto case 5; }
                    if (grainDock == 1) { HarborKind = "GrainDock"; grainDock--; }
                    break;

                case 5:
                    if (oreDock < 1) { randomDock = 5; goto case 6; }
                    if (oreDock == 1) { HarborKind = "OreDock"; oreDock--; }
                    break;

                //case 6:
                //    if (generalDock == 0) { randomDock = 6; goto case 1; }
                //    if (generalDock > 0) { HarborKind = "GeneralDock"; generalDock--; }
                //    break;

                case 6:
                    if (generalDock1 < 1) { randomDock = 6; goto case 7; }
                    if (generalDock1 == 1) { HarborKind = "GeneralDock"; generalDock1--; }
                    break;

                case 7:
                    if (generalDock2 < 1) { randomDock = 7; goto case 8; }
                    if (generalDock2 == 1) { HarborKind = "GeneralDock"; generalDock2--; }
                    break;

                case 8:
                    if (generalDock3 < 1) { randomDock = 8; goto case 9; }
                    if (generalDock3 == 1) { HarborKind = "GeneralDock"; generalDock3--; }
                    break;

                case 9:
                    if (generalDock4 < 1) { randomDock = 9; goto case 1; }
                    if (generalDock4 == 1) { HarborKind = "GeneralDock"; generalDock4--; }
                    break;
            }
            return $"../Images/{HarborKind}.png";
        }
    }
}
