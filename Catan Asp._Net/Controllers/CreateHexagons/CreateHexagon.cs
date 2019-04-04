using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using Catan_Asp._Net.Models;

namespace Catan_Asp._Net.Controllers.CreateHexagons
{
    public class CreateHexagon
    {
        private List<int> numbers = new List<int>();
        public List<int> waardes = new List<int>();
        private List<int> punten = new List<int>();
        private List<int> topdrie = new List<int>();
        int waarde;
        int position = 1;


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


        public List<int> ChooseBestPositions()
        {
            // int[] to choose the numbers 6 & 8
            int[] positions = new int[] { };

            Random r = new Random();
            int ChooseBestPositions = r.Next(1, 7);
            switch (ChooseBestPositions)
            {
                case 1:
                    positions = new int[] { 5, 7, 16, 19 };
                    break;
                case 2:
                    positions = new int[] { 6, 10, 13, 24 };
                    break;
                case 3:
                    positions = new int[] { 12, 20, 29, 31 };
                    break;
                case 4:
                    positions = new int[] { 10, 23, 26, 30 };
                    break;
                case 5:
                    positions = new int[] { 18, 20, 29, 31 };
                    break;
                case 6:
                    positions = new int[] { 2, 18, 23, 26 };
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
                    break;
                case 3:
                    hexagon.Font_size = FontSizeNot2and12;
                    hexagon.Color = "black";
                    hexagon.Hexagonnumber = "••";
                    break;
                case 4:
                    hexagon.Font_size = FontSizeNot2and12;
                    hexagon.Color = "black";
                    hexagon.Hexagonnumber = "•••";
                    break;
                case 5:
                    hexagon.Font_size = FontSizeNot2and12;
                    hexagon.Color = "black";
                    hexagon.Hexagonnumber = "••••";
                    break;
                case 6:
                    hexagon.Font_size = FontSizeNot2and12;
                    hexagon.Color = "red";
                    hexagon.Hexagonnumber = "•••••";
                    break;
                case 8:
                    hexagon.Font_size = FontSizeNot2and12;
                    hexagon.Color = "red";
                    hexagon.Hexagonnumber = "•••••";
                    break;
                case 9:
                    hexagon.Font_size = FontSizeNot2and12;
                    hexagon.Color = "black";
                    hexagon.Hexagonnumber = "••••";
                    break;
                case 10:
                    hexagon.Font_size = FontSizeNot2and12;
                    hexagon.Color = "black";
                    hexagon.Hexagonnumber = "•••";
                    break;
                case 11:
                    hexagon.Font_size = 28;
                    hexagon.Color = "black";
                    hexagon.Hexagonnumber = "••";
                    break;
                case 12:
                    hexagon.Font_size = 24;
                    hexagon.Color = "black";
                    hexagon.Hexagonnumber = "•";
                    break;

            }
            return hexagon;
        }
        public void CalculatePoints()
        {
            for (int i = 1; i < 25; i++)
            {
                switch (i)
                {
                    case 1:
                        punten.Add(waardes[1] + waardes[4] + waardes[5]);
                        break;
                    case 2:
                        punten.Add(waardes[1] + waardes[2] + waardes[5]);
                        break;
                    case 3:
                        punten.Add(waardes[2] + waardes[4] + waardes[5]);
                        break;
                    case 4:
                        punten.Add(waardes[2] + waardes[3] + waardes[6]);
                        break;
                    case 5:
                        punten.Add(waardes[3] + waardes[6] + waardes[7]);
                        break;
                    case 6:
                        punten.Add(waardes[4] + waardes[8] + waardes[9]);
                        break;
                    case 7:
                        punten.Add(waardes[4] + waardes[5] + waardes[9]);
                        break;
                    case 8:
                        punten.Add(waardes[5] + waardes[9] + waardes[10]);
                        break;
                    case 9:
                        punten.Add(waardes[5] + waardes[6] + waardes[10]);
                        break;
                    case 10:
                        punten.Add(waardes[6] + waardes[10] + waardes[11]);
                        break;
                    case 11:
                        punten.Add(waardes[6] + waardes[7] + waardes[11]);
                        break;
                    case 12:
                        punten.Add(waardes[7] + waardes[11] + waardes[12]);
                        break;
                    case 13:
                        punten.Add(waardes[8] + waardes[9] + waardes[13]);
                        break;
                    case 14:
                        punten.Add(waardes[9] + waardes[13] + waardes[14]);
                        break;
                    case 15:
                        punten.Add(waardes[9] + waardes[10] + waardes[14]);
                        break;
                    case 16:
                        punten.Add(waardes[10] + waardes[14] + waardes[15]);
                        break;
                    case 17:
                        punten.Add(waardes[10] + waardes[11] + waardes[15]);
                        break;
                    case 18:
                        punten.Add(waardes[11] + waardes[15] + waardes[16]);
                        break;
                    case 19:
                        punten.Add(waardes[11] + waardes[12] + waardes[16]);
                        break;
                    case 20:
                        punten.Add(waardes[13] + waardes[14] + waardes[17]);
                        break;
                    case 21:
                        punten.Add(waardes[14] + waardes[17] + waardes[18]);
                        break;
                    case 22:
                        punten.Add(waardes[14] + waardes[15] + waardes[18]);
                        break;
                    case 23:
                        punten.Add(waardes[15] + waardes[18] + waardes[19]);
                        break;
                    case 24:
                        punten.Add(waardes[15] + waardes[16] + waardes[19]);
                        break;

                }
            }
            for (int i = 0; i < 3; i++)
            {
                topdrie.Add(punten.Max());
                punten.Remove(punten.Max());
            }
        }
    }
}