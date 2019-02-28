using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catan_Asp._Net.Views.Catan
{
    public class Materials
    {
        Random R = new Random();
        public int MaterialChooser;
        public int count;
        //Materials\\               Randomnumber
         public int Desertcount = 1;     //1
         int Woodcount = 4;       //2
         int Orecount = 3;        //3
         int Stonecount = 3;      //4
         int Woolcount = 4;       //5
         int Graincount = 4;      //6

        public int ChooseMaterial()
        {
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
            if (MaterialChooser == 1) { count = Desertcount; Desertcount--; }
            if (MaterialChooser == 2) { count = Woodcount;  Woodcount--; }
            if (MaterialChooser == 3) { count = Orecount; Orecount--; }
            if (MaterialChooser == 4) { count = Stonecount; Stonecount--;}
            if (MaterialChooser == 5) { count = Woolcount; Woolcount--; }
            if (MaterialChooser == 6) { count = Graincount; Graincount--; }

            return count;

        }


    }
}