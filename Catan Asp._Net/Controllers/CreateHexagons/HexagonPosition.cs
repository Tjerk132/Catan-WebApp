using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catan_Asp._Net.Controllers.CreateHexagons
{
    public class HexagonPosition
    {
        int margin_left = 183;  //Start x-position for 1st row
        int margin_top = -63;   //Start y-position for 1st row
        public int Margin_Left(int i)
        {
            margin_left += 110;
            switch (i)
            {
                case 4:
                    { margin_left = 238; }  //2nd row
                    break;
                case 9:
                    { margin_left = 184; }  //3rd row
                    break;
                case 15:
                    { margin_left = 130; }  //4th row
                    break;
                case 22:
                    { margin_left = 183; }  //5th row
                    break;
                case 28:
                    { margin_left = 237; }  //6th row
                    break;
                case 33:
                    { margin_left = 291; }  //7th row
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
                    { margin_top = 124; }  //3rd row
                    break;
                case 15:
                    { margin_top = 217; }  //4th row
                    break;
                case 22:
                    { margin_top = 310; }  //5th row
                    break;
                case 28:
                    { margin_top = 403; } //6th row
                    break;
                case 33:
                    { margin_top = 496; }  //7th row
                    break;
            }
            return margin_top;
        }
    }

}
