using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catan_Asp._Net.Views.Catan
{
    public class HexagonPosition
    {
        public int NewMaterialchooser;  //random int for material assignment

        public int new_margin_left;
        public int new_margin_top;

        public int margin_leftnumber;
        public void Margin_Left(int i, int margin_left)
        {
            margin_left += 104; //leave 104px between all tiles
            switch (i)
            {
                case 4:
                    { margin_left = 254; }   //2nd row
                    break;
                case 9:
                    { margin_left = 202; }  //3rd row
                    break;
                case 15:
                    { margin_left = 150; }  //4th row
                    break;
                case 22:
                    { margin_left = 202; }  //5th row
                    break;
                case 28:
                    { margin_left = 254; } //6th row
                    break;
                case 33:
                    { margin_left = 306; }  //7th row
                    break;
            }
            new_margin_left = margin_left;
            margin_leftnumber = margin_left + 22;
        }
        public void Margin_Top(int i, int margin_top)
        {
            switch (i)
            {
                case 4:
                    { margin_top = 21; }   //2nd row
                    break;
                case 9:
                    { margin_top = 104; }  //3rd row
                    break;
                case 15:
                    { margin_top = 187; }  //4th row
                    break;
                case 22:
                    { margin_top = 270; }  //5th row
                    break;
                case 28:
                    { margin_top = 353; } //6th row
                    break;
                case 33:
                    { margin_top = 436; }  //7th row
                    break;
            }
            new_margin_top = margin_top;
        }
    }
}