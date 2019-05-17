using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace HexagonLogic.CreateHexagons
{
    public class Materials
    {
        //Materials\\         Randomnumber
        private int Desertcount = 1;     //1
        private int Woodcount = 4;       //2
        private int Orecount = 3;        //3
        private int Stonecount = 3;      //4
        private int Woolcount = 4;       //5
        private int Graincount = 4;      //6


        public string HexagonMaterial(int MaterialChooser, int i, List<int> SixAndEight)
        {
            string HexagonId = "";

            switch (MaterialChooser)
            {
                case 1:
                    if (Desertcount == 0) { MaterialChooser++; goto case 2; }
                    if (!SixAndEight.Contains(i))
                    {
                        HexagonId = "hexagondesert"; Desertcount--;
                    }
                    else { MaterialChooser++; goto case 2; }
                    break;
                case 2:
                    if (Woodcount == 0) { MaterialChooser++; goto case 3; }
                    else HexagonId = "hexagonwood"; Woodcount--;
                    break;
                case 3:
                    if (Orecount == 0) { MaterialChooser++; goto case 4; }
                    else HexagonId = "hexagonore"; Orecount--;
                    break;
                case 4:
                    if (Stonecount == 0) { MaterialChooser++; goto case 5; }
                    else HexagonId = "hexagonstone"; Stonecount--;
                    break;
                case 5:
                    if (Woolcount == 0) { MaterialChooser++; goto case 6; }
                    else HexagonId = "hexagonwool"; Woolcount--;
                    break;
                case 6:
                    if (Graincount == 0) { MaterialChooser++; goto case 1; }
                    else HexagonId = "hexagongrain"; Graincount--;
                    break;
            }
            return HexagonId;
        }
        
    }
}