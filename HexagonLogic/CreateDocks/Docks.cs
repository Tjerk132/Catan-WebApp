using Models.Models;
using System;
using System.Collections.Generic;

namespace HexagonLogic.CreateDocks
{
    public class Docks
    {
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