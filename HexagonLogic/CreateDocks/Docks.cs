using Models.Models;
using System;
using System.Collections.Generic;

namespace HexagonLogic.CreateDocks
{
    public class Docks
    {
        private int randomDock;
        private int woodDock = 1;
        private int stoneDock = 1;
        private int sheepDock = 1;
        private int grainDock = 1;
        private int oreDock = 1;
        private int generalDock = 4;

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

            string HarborKind = "";
            switch(randomDock)
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

                case 6:
                if (generalDock == 0) { randomDock = 6; goto case 1; }
                if (generalDock > 0) { HarborKind = "GeneralDock"; generalDock--; }
                    break;
            }
            string path = $"../Images/{HarborKind}.png";
            return path;
        }

        public DockLines DockLine(int i)
        {
            DockLines dockLine = new DockLines
            {
                top = Top(i),
                left = Left(i),
                degree = Degree(i)
            };

            return dockLine;
        }

        public int Top(int i)
        {
            int top = 0;

            switch (i)
            {
                case 1:
                    top = 88; 
                    break;
                case 2:
                    top = 65; 
                    break;
                case 3:
                     top = 66; 
                    break;
                case 4:
                     top = 88; 
                    break;
                case 5:
                     top = 158; 
                    break;
                case 6:
                     top = 181; 
                    break;
                case 7:
                     top = 201; 
                    break;
                case 8:
                     top = 251; 
                    break;
                case 9:
                     top = 293; 
                    break;
                case 10:
                     top = 346; 
                    break;
                case 11:
                     top = 387; 
                    break;
                case 12:
                     top = 439; 
                    break;
                case 13:
                     top = 481; 
                    break;
                case 14:
                     top = 463; 
                    break;
                case 15:
                     top = 558; 
                    break;
                case 16:
                     top = 575; 
                    break;
                case 17:
                     top = 575; 
                    break;
                case 18:
                     top = 558; 
                    break;
            }

            return top;
        }

        public int Left(int i)
        {
            int left = 0;

            switch (i)
            {
                case 1:
                    left = 250; 
                    break;
                case 2:
                    left = 291; 
                    break;
                case 3:
                    left = 422; 
                    break;
                case 4:
                    left = 465; 
                    break;
                case 5:
                    left = 585; 
                    break;
                case 6:
                    left = 628; 
                    break;
                case 7:
                    left = 183; 
                    break;
                case 8:
                    left = 183; 
                    break;
                case 9:
                    left = 695; 
                    break;
                case 10:
                    left = 694; 
                    break;
                case 11:
                    left = 183; 
                    break;
                case 12:
                    left = 183; 
                    break;
                case 13:
                    left = 586; 
                    break;
                case 14:
                    left = 628; 
                    break;
                case 15:
                    left = 251; 
                    break;
                case 16:
                    left = 295; 
                    break;
                case 17:
                    left = 424; 
                    break;
                case 18:
                    left = 467; 
                    break;
            }

            return left;
        }

        public int Degree(int i)
        {
            int degree = 0;

            switch (i)
            {
                case 1:
                    break;
                case 2:
                    degree = 118; 
                    break;
                case 3:
                    degree = 62; 
                    break;
                case 4:
                    break;
                case 5:
                    degree = 62; 
                    break;
                case 6:
                    break;
                case 7:
                    degree = 62; 
                    break;
                case 8:
                    degree = 118; 
                    break;
                case 9:
                     degree = 118; 
                    break;
                case 10:
                    degree = 62; 
                    break;
                case 11:
                    degree = 62; 
                    break;
                case 12:
                    degree = 118; 
                    break;
                case 13:
                    degree = 118;
                    break;
                case 14:
                    break;
                case 15:
                    break;
                case 16:
                    degree = 62; 
                    break;
                case 17:
                    degree = 118; 
                    break;
                case 18:
                    break;
            }

            return degree;
        }
    }
}