using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catan_Asp._Net.Controllers.CreateHexagons
{
    public class HexagonPosition
    {
        private int margin_left;  //Start x-position for 1st row
        private int margin_top = -63;   //Start y-position for 1st row
        public int Margin_Left(int i)
        {
            margin_left += 108;
            switch (i)
            {
                case 4:
                    { margin_left = 54; }  //2nd row
                    break;
                case 9:
                    { margin_left = 1; }  //3rd row
                    break;
                case 15:
                    { margin_left = -52; }  //4th row
                    break;
                case 22:
                    { margin_left = 1; }  //5th row
                    break;
                case 28:
                    { margin_left = 56; }  //6th row
                    break;
                case 33:
                    { margin_left = 110; }  //7th row
                    break;
            }
            return margin_left;
        }
        public int Margin_LeftNumbers(int margin_left)
        {
            int margin_leftnumber;
            margin_leftnumber = margin_left + 20;
            return margin_leftnumber;
        }
        public int Margin_Top(int i)
        {
            switch (i)
            {
                case 4:
                    { margin_top = 30; }   //2nd row
                    break;
                case 9:
                    { margin_top = 123; }  //3rd row
                    break;
                case 15:
                    { margin_top = 217; }  //4th row
                    break;
                case 22:
                    { margin_top = 311; }  //5th row
                    break;
                case 28:
                    { margin_top = 405; } //6th row
                    break;
                case 33:
                    { margin_top = 499; }  //7th row
                    break;
            }
            return margin_top;
        }
    }

}
