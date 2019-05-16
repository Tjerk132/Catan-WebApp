using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using Catan_Asp._Net.Models;

namespace Catan_Asp._Net.Controllers.CreateHexagons
{
    public class Drawnumber
    {
        private List<int> hexWaarde = new List<int>();
        private int[,] score = new int[24, 5];
        private List<int> topDrieWaarde = new List<int>();
        private int[,] topDrie = new int[2, 3];


        //Numbers\\
        int two = 1;
        int three = 2;
        int four = 2;
        int five = 2;
        int six = 2;

        int eight = 2;
        int nine = 2;
        int ten = 2;
        int eleven = 2;
        int twelve = 1;

        public int[,] TopDrie()
        {
            score[0, 0] = 0; score[0, 1] = 3; score[0, 2] = 4; score[0, 3] = hexWaarde[0] + hexWaarde[3] + hexWaarde[4];
            score[1, 0] = 0; score[1, 1] = 1; score[1, 2] = 4; score[1, 3] = hexWaarde[0] + hexWaarde[1] + hexWaarde[4];
            score[2, 0] = 1; score[2, 1] = 4; score[2, 2] = 5; score[2, 3] = hexWaarde[1] + hexWaarde[4] + hexWaarde[5];
            score[3, 0] = 1; score[3, 1] = 2; score[3, 2] = 5; score[3, 3] = hexWaarde[1] + hexWaarde[2] + hexWaarde[5];
            score[4, 0] = 2; score[4, 1] = 5; score[4, 2] = 6; score[4, 3] = hexWaarde[2] + hexWaarde[5] + hexWaarde[6];
            score[5, 0] = 3; score[5, 1] = 7; score[5, 2] = 9; score[5, 3] = hexWaarde[3] + hexWaarde[7] + hexWaarde[9];
            score[6, 0] = 3; score[6, 1] = 4; score[6, 2] = 8; score[6, 3] = hexWaarde[3] + hexWaarde[4] + hexWaarde[8];
            score[7, 0] = 4; score[7, 1] = 8; score[7, 2] = 9; score[7, 3] = hexWaarde[4] + hexWaarde[8] + hexWaarde[9];
            score[8, 0] = 4; score[8, 1] = 5; score[8, 2] = 9; score[8, 3] = hexWaarde[4] + hexWaarde[5] + hexWaarde[9];
            score[9, 0] = 5; score[9, 1] = 9; score[9, 2] = 10; score[9, 3] = hexWaarde[5] + hexWaarde[9] + hexWaarde[10];
            score[10, 0] = 5; score[10, 1] = 6; score[10, 2] = 10; score[10, 3] = hexWaarde[5] + hexWaarde[6] + hexWaarde[10];
            score[11, 0] = 6; score[11, 1] = 10; score[11, 2] = 11; score[11, 3] = hexWaarde[6] + hexWaarde[10] + hexWaarde[11];
            score[12, 0] = 7; score[12, 1] = 8; score[12, 2] = 12; score[12, 3] = hexWaarde[7] + hexWaarde[8] + hexWaarde[12];
            score[13, 0] = 8; score[13, 1] = 12; score[13, 2] = 13; score[13, 3] = hexWaarde[8] + hexWaarde[12] + hexWaarde[13];
            score[14, 0] = 8; score[14, 1] = 9; score[14, 2] = 13; score[14, 3] = hexWaarde[8] + hexWaarde[9] + hexWaarde[13];
            score[15, 0] = 9; score[15, 1] = 13; score[15, 2] = 14; score[15, 3] = hexWaarde[9] + hexWaarde[13] + hexWaarde[14];
            score[16, 0] = 9; score[16, 1] = 10; score[16, 2] = 14; score[16, 3] = hexWaarde[9] + hexWaarde[10] + hexWaarde[14];
            score[17, 0] = 10; score[17, 1] = 14; score[17, 2] = 15; score[17, 3] = hexWaarde[10] + hexWaarde[14] + hexWaarde[15];
            score[18, 0] = 10; score[18, 1] = 11; score[18, 2] = 15; score[18, 3] = hexWaarde[10] + hexWaarde[11] + hexWaarde[15];
            score[19, 0] = 12; score[19, 1] = 13; score[19, 2] = 16; score[19, 3] = hexWaarde[12] + hexWaarde[13] + hexWaarde[16];
            score[20, 0] = 13; score[20, 1] = 16; score[20, 2] = 17; score[20, 3] = hexWaarde[13] + hexWaarde[16] + hexWaarde[17];
            score[21, 0] = 13; score[21, 1] = 14; score[21, 2] = 17; score[21, 3] = hexWaarde[13] + hexWaarde[14] + hexWaarde[17];
            score[22, 0] = 14; score[22, 1] = 17; score[22, 2] = 18; score[22, 3] = hexWaarde[14] + hexWaarde[17] + hexWaarde[18];
            score[23, 0] = 14; score[23, 1] = 15; score[23, 2] = 18; score[23, 3] = hexWaarde[14] + hexWaarde[15] + hexWaarde[18];

            topDrieWaarde[0] = hexWaarde[0] + hexWaarde[3] + hexWaarde[4];
            topDrieWaarde[1] = hexWaarde[0] + hexWaarde[1] + hexWaarde[4];
            topDrieWaarde[2] = hexWaarde[1] + hexWaarde[4] + hexWaarde[5];
            topDrieWaarde[3] = hexWaarde[1] + hexWaarde[2] + hexWaarde[5];
            topDrieWaarde[4] = hexWaarde[2] + hexWaarde[5] + hexWaarde[6];
            topDrieWaarde[5] = hexWaarde[3] + hexWaarde[7] + hexWaarde[9];
            topDrieWaarde[6] = hexWaarde[3] + hexWaarde[4] + hexWaarde[8];
            topDrieWaarde[7] = hexWaarde[4] + hexWaarde[8] + hexWaarde[9];
            topDrieWaarde[8] = hexWaarde[4] + hexWaarde[5] + hexWaarde[9];
            topDrieWaarde[9] = hexWaarde[5] + hexWaarde[9] + hexWaarde[10];
            topDrieWaarde[10] = hexWaarde[5] + hexWaarde[6] + hexWaarde[10];
            topDrieWaarde[11] = hexWaarde[6] + hexWaarde[10] + hexWaarde[11];
            topDrieWaarde[12] = hexWaarde[7] + hexWaarde[8] + hexWaarde[12];
            topDrieWaarde[13] = hexWaarde[8] + hexWaarde[12] + hexWaarde[13];
            topDrieWaarde[14] = hexWaarde[8] + hexWaarde[9] + hexWaarde[13];
            topDrieWaarde[15] = hexWaarde[9] + hexWaarde[13] + hexWaarde[14];
            topDrieWaarde[16] = hexWaarde[9] + hexWaarde[10] + hexWaarde[14];
            topDrieWaarde[17] = hexWaarde[10] + hexWaarde[14] + hexWaarde[15];
            topDrieWaarde[18] = hexWaarde[10] + hexWaarde[11] + hexWaarde[15];
            topDrieWaarde[19] = hexWaarde[12] + hexWaarde[13] + hexWaarde[16];
            topDrieWaarde[20] = hexWaarde[13] + hexWaarde[16] + hexWaarde[17];
            topDrieWaarde[21] = hexWaarde[13] + hexWaarde[14] + hexWaarde[17];
            topDrieWaarde[22] = hexWaarde[14] + hexWaarde[17] + hexWaarde[18];
            topDrieWaarde[23] = hexWaarde[14] + hexWaarde[15] + hexWaarde[18];

            for (int i = 0; i < 3; i++)
            {
                topDrie[i, 0] = topDrieWaarde.Max(); topDrie[i, 1] = topDrieWaarde.IndexOf(topDrieWaarde.Max());
                topDrieWaarde[topDrieWaarde.IndexOf(topDrieWaarde.Max())] = 0;
            }

            return topDrie;
        }

        public List<int> ChooseBestPositions()
        {
            // int[] to choose the numbers 6 & 8
            int[] positions = new int[] { };

            Random r = new Random();
            int ChooseBestPositions = r.Next(1, 5);
            switch (ChooseBestPositions)
            {
                case 1:
                    positions = new int[] { 5, 7, 16, 18 };
                    break;
                case 2:
                    positions = new int[] { 6, 10, 13, 18 };
                    break;
                case 3:
                    positions = new int[] { 18, 20, 29, 31 };
                    break;
                case 4:
                    positions = new int[] { 18, 23, 26, 30 };
                    break;
            }
            //List int that contains the hexes for 6 & 8
            List<int> SixAndEightPositions = new List<int>();
            SixAndEightPositions.AddRange(positions);

            return SixAndEightPositions;
        }
        public List<int> Playgroundhexes()
        {
            int[] playgroundhexes = new int[] { 5, 6, 7, 10, 11, 12, 13, 16, 17, 18, 19, 20, 23, 24, 25, 26, 29, 30, 31 };
            List<int> PlaygroundHexes = new List<int>();
            PlaygroundHexes.AddRange(playgroundhexes);
            return PlaygroundHexes;
        }


        public HexagonTile MakeHexagon(int RandomNumber, int i, string HexagonId, List<int>SixAndEightPositions)
        {
            HexagonTile hexagon = new HexagonTile
            {
                Id = HexagonId
            };

            //Set Number to hexagon \\
            //only if hexagon is not a desert
            if (hexagon.Id != "hexagondesert")
            {
                //if hexagon is a hexagon for 6 or 8
                if (SixAndEightPositions.Contains(i))
                {
                    Random r = new Random();
                    RandomNumber = r.Next(6, 9);
                    
                    switch (RandomNumber)
                    {
                        case 6:
                            if (six > 0) { RandomNumber = 6; six--; }
                            else { goto case 8; }
                            break;
                        case 7: RandomNumber = 8; goto case 8;
                        case 8:
                            if (eight > 0) { RandomNumber = 8; eight--; }
                            else { goto case 6; }
                            break;
                    }
                }
                // if hexagon is a hexagon that could have all numbers, except 6 & 8
                else
                {
                    switch (RandomNumber)
                    {
                        case 2:
                            if (two > 0) { two--; }
                            else { RandomNumber = 3; goto case 3; }
                            break;

                        case 3:
                            if (three > 0) { three--; }
                            else { RandomNumber = 4; goto case 4; }
                            break;

                        case 4:
                            if (four > 0) { four--; }
                            else { RandomNumber = 5; goto case 5; }
                            break;

                        case 5:
                            if (five > 0) { five--; }
                            else { RandomNumber = 6; goto case 6; }
                            break;

                        case 6: RandomNumber = 7; goto case 7;

                        case 7: RandomNumber = 8; goto case 8;

                        case 8: RandomNumber = 9; goto case 9;

                        case 9:
                            if (nine > 0) { nine--; }
                            else { RandomNumber = 10; goto case 10; }
                            break;

                        case 10:
                            if (ten > 0) { ten--; }
                            else { RandomNumber = 11; goto case 11; }
                            break;

                        case 11:
                            if (eleven > 0) { eleven--; }
                            else { RandomNumber = 12; goto case 12; }
                            break;
                        case 12:
                            if (twelve > 0) { twelve--; }
                            else { RandomNumber = 2; goto case 2; }
                            break;
                    }
                }
                hexagon.Number = RandomNumber;
            }
            //if hexagon is desert
            else
            {
                hexagon.Class = "rover";
                hexWaarde.Add(0);
            }

            //give circle-text values to hexagon \\
            //number font-size, number color & hexagonnumber dots
            int FontSizeNot2and12 = 28;

            switch (hexagon.Number)
            {
                case 2:
                    hexagon.Font_size = 24;
                    hexagon.Color = "black";
                    hexagon.Hexagonnumber = "•";
                    hexWaarde.Add(1);
                    break;
                case 3:
                    hexagon.Font_size = FontSizeNot2and12;
                    hexagon.Color = "black";
                    hexagon.Hexagonnumber = "••";
                    hexWaarde.Add(2);
                    break;
                case 4:
                    hexagon.Font_size = FontSizeNot2and12;
                    hexagon.Color = "black";
                    hexagon.Hexagonnumber = "•••";
                    hexWaarde.Add(3);
                    break;
                case 5:
                    hexagon.Font_size = FontSizeNot2and12;
                    hexagon.Color = "black";
                    hexagon.Hexagonnumber = "••••";
                    hexWaarde.Add(4);
                    break;
                case 6:
                    hexagon.Font_size = FontSizeNot2and12;
                    hexagon.Color = "red";
                    hexagon.Hexagonnumber = "•••••";
                    hexWaarde.Add(5);
                    break;
                case 8:
                    hexagon.Font_size = FontSizeNot2and12;
                    hexagon.Color = "red";
                    hexagon.Hexagonnumber = "•••••";
                    hexWaarde.Add(5);
                    break;
                case 9:
                    hexagon.Font_size = FontSizeNot2and12;
                    hexagon.Color = "black";
                    hexagon.Hexagonnumber = "••••";
                    hexWaarde.Add(4);
                    break;
                case 10:
                    hexagon.Font_size = FontSizeNot2and12;
                    hexagon.Color = "black";
                    hexagon.Hexagonnumber = "•••";
                    hexWaarde.Add(3);
                    break;
                case 11:
                    hexagon.Font_size = 28;
                    hexagon.Color = "black";
                    hexagon.Hexagonnumber = "••";
                    hexWaarde.Add(2);
                    break;
                case 12:
                    hexagon.Font_size = 24;
                    hexagon.Color = "black";
                    hexagon.Hexagonnumber = "•";
                    hexWaarde.Add(1);
                    break;

            }
            return hexagon;
        }
    }
}