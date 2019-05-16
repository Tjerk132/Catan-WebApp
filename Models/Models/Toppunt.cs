using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Toppunt
    {
        public Toppunt(int plaats, int waarde)
        {
            Plaats = plaats;
            Waarde = waarde;
            switch (plaats)
            {
                case 0:
                    Left = 292;
                    Top = 180;
                    break;
                case 1:
                    Left = 347;
                    Top = 160;
                    break;
                case 2:
                    Left = 400;
                    Top = 180;
                    break;
                case 3:
                    Left = 455;
                    Top = 160;
                    break;
                case 4:
                    Left = 510;
                    Top = 180;
                    break;
                case 5:
                    Left = 239;
                    Top = 270;
                    break;
                case 6:
                    Left = 292;
                    Top = 250;
                    break;
                case 7:
                    Left = 347;
                    Top = 270;
                    break;
                case 8:
                    Left = 400;
                    Top = 250;
                    break;
                case 9:
                    Left = 455;
                    Top = 270;
                    break;
                case 10:
                    Left = 510;
                    Top = 250;
                    break;
                case 11:
                    Left = 565;
                    Top = 270;
                    break;
                case 12:
                    Left = 239;
                    Top = 350;
                    break;
                case 13:
                    Left = 292;
                    Top = 370;
                    break;
                case 14:
                    Left = 347;
                    Top = 350;
                    break;
                case 15:
                    Left = 400;
                    Top = 370;
                    break;
                case 16:
                    Left = 455;
                    Top = 350;
                    break;
                case 17:
                    Left = 510;
                    Top = 370;
                    break;
                case 18:
                    Left = 565;
                    Top = 350;
                    break;
                case 19:
                    Left = 292;
                    Top = 440;
                    break;
                case 20:
                    Left = 347;
                    Top = 460;
                    break;
                case 21:
                    Left = 400;
                    Top = 440;
                    break;
                case 22:
                    Left = 455;
                    Top = 460;
                    break;
                case 23:
                    Left = 510;
                    Top = 440;
                    break;

            }
        }

        public int Plaats { get; set; }
        public int Waarde { get; set; }
        public int Left { get; set; }
        public int Top { get; set; }
    }
}
