﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using Catan_Asp._Net.Models;

namespace Catan_Asp._Net.Controllers.CreateHexagons
{
    public class Drawnumber
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
        int seven = 1;
        int eight = 2;
        int nine = 2;
        int ten = 2;
        int eleven = 2;
        int twelve = 1;
        int x;

        int LastRandom = 0;

        //public bool MakeNumber(int number)
        //{
        //    if (position == 1)
        //    {
        //        numbers.Add(0);
        //        waardes.Add(0);
        //    }


        //    //numbercircles\\

        //    //Make sure all numbers are assigned and 6 and 8 are not next to eachother\\
        //    while ((number == 7) || (number == 2 && two == 0) || (number == 3 && three == 0) || (number == 4 && four == 0) || (number == 5 && five == 0) || (number == 6 && six == 0) || (number == 8 && eight == 0) || (number == 9 && nine == 0) || (number == 10 && ten == 0) || 
        //(number == 11 && eleven == 0) || (number == 12 && twelve == 0) || ((number == 6 || number == 8) && (lastnumber == 6 || lastnumber == 8)) || (position == 4 && (number == 6 || number == 8) && (numbers[1] == 6 || numbers[1] == 8)) || (position == 5 && 
          //  (number == 6 || number == 8) && ((numbers[1] == 6 || numbers[1] == 8) || (numbers[2] == 6 || numbers[2] == 8))) || (position == 6 && (number == 6 || number == 8) && ((numbers[2] == 6 || numbers[2] == 8) || (numbers[3] == 6 || numbers[3] == 8))) || (position == 7 &&
        //(number == 6 || number == 8) && (numbers[3] == 6 || numbers[3] == 8)) || (position == 8 && (number == 6 || number == 8) && (numbers[4] == 6 || numbers[4] == 8)) || (position == 9 && (number == 6 || number == 8) && ((numbers[4] == 6 || numbers[4] == 8) 
        //|| (numbers[5] == 6 || numbers[5] == 8))) || (position == 10 && (number == 6 || number == 8) && ((numbers[5] == 6 || numbers[5] == 8) || (numbers[6] == 6 || numbers[6] == 8))) || (position == 11 && (number == 6 || number == 8) && ((numbers[6] == 6 || numbers[6] == 8) || 
          //  (numbers[7] == 6 || numbers[7] == 8))) || (position == 12 && (number == 6 || number == 8) && (numbers[7] == 6 || numbers[7] == 8)) || (position == 13 && (number == 6 || number == 8) && ((numbers[8] == 6 || numbers[8] == 8) || (numbers[9] == 6 || numbers[9] == 8)))
        //|| (position == 14 && (number == 6 || number == 8) && ((numbers[9] == 6 || numbers[9] == 8) || (numbers[10] == 6 || numbers[10] == 8))) || (position == 15 && (number == 6 || number == 8) && ((numbers[10] == 6 || numbers[10] == 8) || (numbers[11] == 6 || numbers[11] == 8)))
        //|| (position == 16 && (number == 6 || number == 8) && ((numbers[11] == 6 || numbers[11] == 8) || (numbers[12] == 6 || numbers[12] == 8))) || (position == 17 && (number == 6 || number == 8) && ((numbers[13] == 6 || numbers[13] == 8) || (numbers[14] == 6 || numbers[14] == 8)))
        //|| (position == 18 && (number == 6 || number == 8) && ((numbers[14] == 6 || numbers[14] == 8) || (numbers[15] == 6 || numbers[15] == 8))) || (position == 19 && (number == 6 || number == 8) && ((numbers[15] == 6 || numbers[15] == 8) || (numbers[16] == 6 || numbers[16] == 8))))
        //    {
        //        x++;
        //        if (x == 30)
        //        {
        //            return true;
        //        }
        //        Random r = new Random();
        //        number = r.Next(2, 13);
        //        if (two == 0 && three == 0 && four == 0 && five == 0 && six == 0 && eight == 0 && nine == 0 && ten == 0 && eleven == 0 && twelve == 0)
        //        {
        //            break;
        //        }
        //    }

        //    while ((position == 4 && (number == 6 || number == 8) && (numbers[1] == 6 || numbers[1] == 8)))

        //        lastnumber = number;
        //    numbers.Add(number);
        //    if (number == 2 || number == 12)
        //    {
        //        waarde = 1;
        //    }
        //    else if (number == 3 || number == 11)
        //    {
        //        waarde = 2;
        //    }
        //    else if (number == 4 || number == 10)
        //    {
        //        waarde = 3;
        //    }
        //    else if (number == 5 || number == 9)
        //    {
        //        waarde = 4;
        //    }
        //    else if (number == 6 || number == 8)
        //    {
        //        waarde = 5;
        //    }
        //    else if (number == 7)
        //    {
        //        waarde = 0;
        //    }
        //    waardes.Add(waarde);
        //    position++;
        //    return false;
        //}

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
        public HexagonTile MakeHexagon(HexagonTile hexagon)
        {
            if (hexagon.Number != 2 && hexagon.Number != 12)
            {
                hexagon.Font_size = 20;
            }
            if (hexagon.Number != 6 && hexagon.Number != 8)
            {
                hexagon.Color = "black";
            }
            if (hexagon.Number == 2 || hexagon.Number == 12)
            {
                hexagon.Hexagonnumber = "•";
                hexagon.Font_size = 16;
            }
            if (hexagon.Number == 3 || hexagon.Number == 11)
            {
                hexagon.Hexagonnumber = "••";
            }
            if (hexagon.Number == 4 || hexagon.Number == 10)
            {
                hexagon.Hexagonnumber = "•••";
            }
            if (hexagon.Number == 5 || hexagon.Number == 9)
            {
                hexagon.Hexagonnumber = "••••";
            }
            if (hexagon.Number == 6 || hexagon.Number == 8)
            {
                hexagon.Hexagonnumber = "•••••";
                hexagon.Color = "red";
            }
            return hexagon;
        }
        public int MakeNumber(int i, int ChooseBestPositions)
        {
            //int[] positions = new int[] { };

            //switch (ChooseBestPositions)
            //{
            //    case 1:
            //        positions = new int[]{ 5, 7, 16, 18 };
            //        break;
            //    case 2:
            //        positions = new int[] { 6, 10, 13, 18 };
            //        break;
            //    case 3:
            //        positions = new int[] { 18, 20, 29, 32 };
            //        break;
            //    case 4:
            //        positions = new int[] { 18, 23, 26, 30 };
            //        break;
            //}

            //List<int> SixAndEightPositions = new List<int>();
            //SixAndEightPositions.AddRange(positions);

            Random r = new Random();
            int HexagonRandom = r.Next(2, 13);

            ////if (!SixAndEightPositions.Contains(i))
            ////{
            //    switch (HexagonRandom)
            //    {
            //        case 2:
            //            if (two > 0) { two--; HexagonRandom = 2; }
            //            else { goto case 3; }
            //            break;
            //        case 3:
            //            if (three > 0) { three--; HexagonRandom = 3; }
            //            else { goto case 4; }
            //            break;
            //        case 4:
            //            if (four > 0) { four--; HexagonRandom = 4; }
            //            else { goto case 5; }
            //            break;
            //        case 5:
            //            if (five > 0) { five--; HexagonRandom = 5; }
            //            else { goto case 9; }
            //            break;
            //        case 6:{ goto case 7; }
            //        case 7: { goto case 8; }
            //        case 8: { goto case 9; }
            //        case 9:
            //            if (nine > 0) { nine--; HexagonRandom = 9; }
            //            else { goto case 10; }
            //            break;
            //        case 10:
            //            if (ten > 0) { ten--; HexagonRandom = 10; }
            //            else { goto case 11; }
            //            break;
            //        case 11:
            //            if (eleven > 0) { eleven--; HexagonRandom = 11; }
            //            else { goto case 12; }
            //            break;
            //        case 12:
            //            if (twelve > 0) { twelve--; HexagonRandom = 12; }
            //            else { goto case 2; }
            //            break;
            //    }
            ////}
            ////else
            ////{
            ////    HexagonRandom = 6;
            ////    switch (HexagonRandom)
            ////    {
            ////        case 6:
            ////            if (six > 0) { six--; HexagonRandom = 6; }
            ////            else { goto case 8; }
            ////            break;
            ////        case 8:
            ////            if (eight > 0) { eight--; HexagonRandom = 8; }
            ////            else { goto case 6; }
            ////            break;
            ////    }

            ////}
            return HexagonRandom;
        }
    }
}