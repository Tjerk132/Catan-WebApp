using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catan_Asp._Net.Controllers.CreateHexagons
{
    public class Docks
    {
        int randomDock;
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

        public DockLines dockLine(int i, int count)
        {
            DockLines dockLine = new DockLines();
            dockLine.top = Top(i, count);
            dockLine.left = Left(i, count);
            dockLine.degree = Degree(i, count);

            return dockLine;
        }

        public int Top(int i, int count)
        {
            int top = 0;

            switch (i)
            {
                case 0:
                    if (count == 0){ top = 88; }
                    else { top = 65; }
                    break;
                case 2:
                    if (count == 0) { top = 66; }
                    else { top = 88; }
                    break;
                case 8:
                    if (count == 0) { top = 158; }
                    else { top = 181; }
                    break;
                case 9:
                    if (count == 0) { top = 201; }
                    else { top = 251; }
                    break;
                case 21:
                    if (count == 0) { top = 293; }
                    else { top = 346; }
                    break;
                case 22:
                    if (count == 0) { top = 387; }
                    else { top = 439; }
                    break;
                case 32:
                    if (count == 0) { top = 481; }
                    else { top = 463; }
                    break;
                case 33:
                    if (count == 0) { top = 558; }
                    else { top = 575; }
                    break;
                case 35:
                    if (count == 0) { top = 575; }
                    else { top = 558; }
                    break;
            }

            return top;
        }

        public int Left(int i, int count)
        {
            int left = 0;

            switch (i)
            {
                case 0:
                    if (count == 0) { left = 433; }
                    else { left = 474; }
                    break;
                case 2:
                    if (count == 0) { left = 606; }
                    else { left = 649; }
                    break;
                case 8:
                    if (count == 0) { left = 769; }
                    else { left = 812; }
                    break;
                case 9:
                    if (count == 0) { left = 367; }
                    else { left = 367; }
                    break;
                case 21:
                    if (count == 0) { left = 878; }
                    else { left = 878; }
                    break;
                case 22:
                    if (count == 0) { left = 367; }
                    else { left = 367; }
                    break;
                case 32:
                    if (count == 0) { left = 770; }
                    else { left = 812; }
                    break;
                case 33:
                    if (count == 0) { left = 435; }
                    else { left = 476; }
                    break;
                case 35:
                    if (count == 0) { left = 608; }
                    else { left = 650; }
                    break;
            }

            return left;
        }

        public int Degree(int i, int count)
        {
            int degree = 0;

            switch (i)
            {
                case 0:
                    if (count == 0) { }
                    else { degree = 118; }
                    break;
                case 2:
                    if (count == 0) { degree = 62; }
                    else { }
                    break;
                case 8:
                    if (count == 0) { degree = 62; }
                    else { }
                    break;
                case 9:
                    if (count == 0) { degree = 62; }
                    else { degree = 118; }
                    break;
                case 21:
                    if (count == 0) { degree = 118; }
                    else { degree = 62; }
                    break;
                case 22:
                    if (count == 0) { degree = 62; }
                    else { degree = 118; }
                    break;
                case 32:
                    if (count == 0) { degree = 118; }
                    else { }
                    break;
                case 33:
                    if (count == 0) { }
                    else { degree = 62; }
                    break;
                case 35:
                    if (count == 0) { degree = 118; }
                    else { }
                    break;
            }

            return degree;
        }
    }
}