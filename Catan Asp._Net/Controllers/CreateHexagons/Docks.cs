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
                    else { top = 68; }
                    break;
                case 2:
                    if (count == 0) { top = 68; }
                    else { top = 88; }
                    break;
                case 8:
                    if (count == 0) { top = 161; }
                    else { top = 181; }
                    break;
                case 9:
                    if (count == 0) { top = 202; }
                    else { top = 254; }
                    break;
                case 21:
                    if (count == 0) { top = 296; }
                    else { top = 348; }
                    break;
                case 22:
                    if (count == 0) { top = 390; }
                    else { top = 442; }
                    break;
                case 32:
                    if (count == 0) { top = 483; }
                    else { top = 463; }
                    break;
                case 33:
                    if (count == 0) { top = 558; }
                    else { top = 578; }
                    break;
                case 35:
                    if (count == 0) { top = 578; }
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
                    if (count == 0) { left = 432; }
                    else { left = 474; }
                    break;
                case 2:
                    if (count == 0) { left = 606; }
                    else { left = 648; }
                    break;
                case 8:
                    if (count == 0) { left = 769; }
                    else { left = 811; }
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
                    if (count == 0) { left = 769; }
                    else { left = 811; }
                    break;
                case 33:
                    if (count == 0) { left = 434; }
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