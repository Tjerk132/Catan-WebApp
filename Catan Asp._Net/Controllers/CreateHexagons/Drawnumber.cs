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
        private List<int> hexGetal = new List<int>();
        private int[,] score = new int[24, 5];
        private List<int> waarde = new List<int>();
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
            score[0, 0] = 0; score[0, 1] = 3; score[0, 2] = 4; score[0, 3] = hexGetal[0] + hexGetal[3] + hexGetal[4];
            score[1, 0] = 0; score[1, 1] = 1; score[1, 2] = 4; score[1, 3] = hexGetal[0] + hexGetal[1] + hexGetal[4];
            score[2, 0] = 1; score[2, 1] = 4; score[2, 2] = 5; score[2, 3] = hexGetal[1] + hexGetal[4] + hexGetal[5];
            score[3, 0] = 1; score[3, 1] = 2; score[3, 2] = 5; score[3, 3] = hexGetal[1] + hexGetal[2] + hexGetal[5];
            score[4, 0] = 2; score[4, 1] = 5; score[4, 2] = 6; score[4, 3] = hexGetal[2] + hexGetal[5] + hexGetal[6];
            score[5, 0] = 3; score[5, 1] = 7; score[5, 2] = 9; score[5, 3] = hexGetal[3] + hexGetal[7] + hexGetal[9];
            score[6, 0] = 3; score[6, 1] = 4; score[6, 2] = 8; score[6, 3] = hexGetal[3] + hexGetal[4] + hexGetal[8];
            score[7, 0] = 4; score[7, 1] = 8; score[7, 2] = 9; score[7, 3] = hexGetal[4] + hexGetal[8] + hexGetal[9];
            score[8, 0] = 4; score[8, 1] = 5; score[8, 2] = 9; score[8, 3] = hexGetal[4] + hexGetal[5] + hexGetal[9];
            score[9, 0] = 5; score[9, 1] = 9; score[9, 2] = 10; score[9, 3] = hexGetal[5] + hexGetal[9] + hexGetal[10];
            score[10, 0] = 5; score[10, 1] = 6; score[10, 2] = 10; score[10, 3] = hexGetal[5] + hexGetal[6] + hexGetal[10];
            score[11, 0] = 6; score[11, 1] = 10; score[11, 2] = 11; score[11, 3] = hexGetal[6] + hexGetal[10] + hexGetal[11];
            score[12, 0] = 7; score[12, 1] = 8; score[12, 2] = 12; score[12, 3] = hexGetal[7] + hexGetal[8] + hexGetal[12];
            score[13, 0] = 8; score[13, 1] = 12; score[13, 2] = 13; score[13, 3] = hexGetal[8] + hexGetal[12] + hexGetal[13];
            score[14, 0] = 8; score[14, 1] = 9; score[14, 2] = 13; score[14, 3] = hexGetal[8] + hexGetal[9] + hexGetal[13];
            score[15, 0] = 9; score[15, 1] = 13; score[15, 2] = 14; score[15, 3] = hexGetal[9] + hexGetal[13] + hexGetal[14];
            score[16, 0] = 9; score[16, 1] = 10; score[16, 2] = 14; score[16, 3] = hexGetal[9] + hexGetal[10] + hexGetal[14];
            score[17, 0] = 10; score[17, 1] = 14; score[17, 2] = 15; score[17, 3] = hexGetal[10] + hexGetal[14] + hexGetal[15];
            score[18, 0] = 10; score[18, 1] = 11; score[18, 2] = 15; score[18, 3] = hexGetal[10] + hexGetal[11] + hexGetal[15];
            score[19, 0] = 12; score[19, 1] = 13; score[19, 2] = 16; score[19, 3] = hexGetal[12] + hexGetal[13] + hexGetal[16];
            score[20, 0] = 13; score[20, 1] = 16; score[20, 2] = 17; score[20, 3] = hexGetal[13] + hexGetal[16] + hexGetal[17];
            score[21, 0] = 13; score[21, 1] = 14; score[21, 2] = 17; score[21, 3] = hexGetal[13] + hexGetal[14] + hexGetal[17];
            score[22, 0] = 14; score[22, 1] = 17; score[22, 2] = 18; score[22, 3] = hexGetal[14] + hexGetal[17] + hexGetal[18];
            score[23, 0] = 14; score[23, 1] = 15; score[23, 2] = 18; score[23, 3] = hexGetal[14] + hexGetal[15] + hexGetal[18];

            waarde[0] = hexGetal[0] + hexGetal[3] + hexGetal[4];
            waarde[1] = hexGetal[0] + hexGetal[1] + hexGetal[4];
            waarde[2] = hexGetal[1] + hexGetal[4] + hexGetal[5];
            waarde[3] = hexGetal[1] + hexGetal[2] + hexGetal[5];
            waarde[4] = hexGetal[2] + hexGetal[5] + hexGetal[6];
            waarde[5] = hexGetal[3] + hexGetal[7] + hexGetal[9];
            waarde[6] = hexGetal[3] + hexGetal[4] + hexGetal[8];
            waarde[7] = hexGetal[4] + hexGetal[8] + hexGetal[9];
            waarde[8] = hexGetal[4] + hexGetal[5] + hexGetal[9];
            waarde[9] = hexGetal[5] + hexGetal[9] + hexGetal[10];
            waarde[10] = hexGetal[5] + hexGetal[6] + hexGetal[10];
            waarde[11] = hexGetal[6] + hexGetal[10] + hexGetal[11];
            waarde[12] = hexGetal[7] + hexGetal[8] + hexGetal[12];
            waarde[13] = hexGetal[8] + hexGetal[12] + hexGetal[13];
            waarde[14] = hexGetal[8] + hexGetal[9] + hexGetal[13];
            waarde[15] = hexGetal[9] + hexGetal[13] + hexGetal[14];
            waarde[16] = hexGetal[9] + hexGetal[10] + hexGetal[14];
            waarde[17] = hexGetal[10] + hexGetal[14] + hexGetal[15];
            waarde[18] = hexGetal[10] + hexGetal[11] + hexGetal[15];
            waarde[19] = hexGetal[12] + hexGetal[13] + hexGetal[16];
            waarde[20] = hexGetal[13] + hexGetal[16] + hexGetal[17];
            waarde[21] = hexGetal[13] + hexGetal[14] + hexGetal[17];
            waarde[22] = hexGetal[14] + hexGetal[17] + hexGetal[18];
            waarde[23] = hexGetal[14] + hexGetal[15] + hexGetal[18];

            for (int i = 0; i < 3; i++)
            {
                topDrie[i, 0] = waarde.Max(); topDrie[i, 1] = waarde.IndexOf(waarde.Max());
                waarde[waarde.IndexOf(waarde.Max())] = 0;
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
                hexGetal.Add(0);
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
                    hexGetal.Add(1);
                    break;
                case 3:
                    hexagon.Font_size = FontSizeNot2and12;
                    hexagon.Color = "black";
                    hexagon.Hexagonnumber = "••";
                    hexGetal.Add(2);
                    break;
                case 4:
                    hexagon.Font_size = FontSizeNot2and12;
                    hexagon.Color = "black";
                    hexagon.Hexagonnumber = "•••";
                    hexGetal.Add(3);
                    break;
                case 5:
                    hexagon.Font_size = FontSizeNot2and12;
                    hexagon.Color = "black";
                    hexagon.Hexagonnumber = "••••";
                    hexGetal.Add(4);
                    break;
                case 6:
                    hexagon.Font_size = FontSizeNot2and12;
                    hexagon.Color = "red";
                    hexagon.Hexagonnumber = "•••••";
                    hexGetal.Add(5);
                    break;
                case 8:
                    hexagon.Font_size = FontSizeNot2and12;
                    hexagon.Color = "red";
                    hexagon.Hexagonnumber = "•••••";
                    hexGetal.Add(5);
                    break;
                case 9:
                    hexagon.Font_size = FontSizeNot2and12;
                    hexagon.Color = "black";
                    hexagon.Hexagonnumber = "••••";
                    hexGetal.Add(4);
                    break;
                case 10:
                    hexagon.Font_size = FontSizeNot2and12;
                    hexagon.Color = "black";
                    hexagon.Hexagonnumber = "•••";
                    hexGetal.Add(3);
                    break;
                case 11:
                    hexagon.Font_size = 28;
                    hexagon.Color = "black";
                    hexagon.Hexagonnumber = "••";
                    hexGetal.Add(2);
                    break;
                case 12:
                    hexagon.Font_size = 24;
                    hexagon.Color = "black";
                    hexagon.Hexagonnumber = "•";
                    hexGetal.Add(1);
                    break;

            }
            return hexagon;
        }
    }
}