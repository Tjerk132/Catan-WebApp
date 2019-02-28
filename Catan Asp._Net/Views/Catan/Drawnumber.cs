using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catan_Asp._Net.Views.Catan
{
    public class Drawnumber
    {
        Random r = new Random();
        public int number;  //random int for number assignment

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

        public void MakeNumber()
        {

            //numbercircles\\
            number = r.Next(2, 13);

            //Make sure all numbers are assigned\\
            while ((number == 7 )|| (number == 2 && two == 0) || (number == 3 && three == 0) || (number == 4 && four == 0) || (number == 5 && five == 0) || (number == 6 && six == 0) || (number == 8 && eight == 0) || (number == 9 && nine == 0) || (number == 10 && ten == 0) || (number == 11 && eleven == 0) || (number == 12 && twelve == 0))
            {
                number = r.Next(2, 13);
                if (two == 0 &&  three == 0 &&  four == 0 && five == 0 && six == 0 && eight == 0 && nine == 0 && ten == 0 && eleven == 0 && twelve == 0)
                {
                    break;
                }
            }

            switch (number)
            {
                    case 2: 
                        two--;
                        break;
                    case 3:
                        three--;
                        break;
                    case 4:
                        four--;
                        break;
                    case 5:
                        five--;
                        break;
                    case 9:
                        nine--;
                        break;
                    case 10:
                        ten--;
                        break;
                    case 11:
                        eleven--;
                        break;
                    case 6:
                        six--;
                        break;
                    case 8:
                        eight--;
                        break;
                    case 12:
                        twelve--;
                        break;
            }
        }          
    }
}