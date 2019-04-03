﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using Catan_Asp._Net.Models;

namespace Catan_Asp._Net.Controllers.CreateHexagons
{
    public class Materials
    {
        Random R = new Random();
         string Material;
        //Materials\\               Randomnumber
         int Desertcount = 1;     //1
         int Woodcount = 4;       //2
         int Orecount = 3;        //3
         int Stonecount = 3;      //4
         int Woolcount = 4;       //5
         int Graincount = 4;      //6

        public string ChooseMaterial()
        {
            int MaterialChooser;
            MaterialChooser = R.Next(1, 7);

            //Make sure all materials are assigned\\
            for (int a = 0; a < 2; a++)
            {
                if (MaterialChooser == 1 && Desertcount == 0) { MaterialChooser++;}

                if (MaterialChooser == 2 && Woodcount == 0) {MaterialChooser++; }

                if (MaterialChooser == 3 && Orecount == 0) {MaterialChooser++;}

                if (MaterialChooser == 4 && Stonecount == 0) { MaterialChooser++;}

                if (MaterialChooser == 5 && Woolcount == 0) { MaterialChooser++;}

                if (MaterialChooser == 6 && Graincount == 0) { MaterialChooser = 1;}
            }
            if (MaterialChooser == 1) { Material = "hexagondesert"; Desertcount--; }
            if (MaterialChooser == 2) { Material = "hexagonwood";  Woodcount--; }
            if (MaterialChooser == 3) { Material = "hexagonore"; Orecount--; }
            if (MaterialChooser == 4) { Material = "hexagonstone"; Stonecount--;}
            if (MaterialChooser == 5) { Material = "hexagonwool"; Woolcount--; }
            if (MaterialChooser == 6) { Material = "hexagongrain"; Graincount--; }

            return Material;
        }
        //public string ReturnHexagon(int Materialchooser, HexagonTile hexagon)
        //{
        //    //if (MaterialChooser == 1)
        //    //{
        //    //    hexagon.Id = "hexagondesert";
        //    //}
        //    //if (MaterialChooser == 2)
        //    //{
        //    //    hexagon.Id = "hexagonwood";
        //    //}
        //    //if (MaterialChooser == 3)
        //    //{
        //    //    hexagon.Id = "hexagonore";
        //    //}
        //    //if (MaterialChooser == 4)
        //    //{
        //    //    hexagon.Id = "hexagonstone";
        //    //}
        //    //if (MaterialChooser == 5)
        //    //{
        //    //    hexagon.Id = "hexagonwool";

        //    //}
        //    //if (MaterialChooser == 6)
        //    //{
        //    //    hexagon.Id = "hexagongrain";
        //    //}
        //    return hexagon.Id;
        //}
    }
}