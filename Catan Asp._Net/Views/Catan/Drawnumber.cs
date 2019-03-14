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
        private List<int> numbers = new List<int>();
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
        int lastnumber;

        public void MakeNumber()
        {
            if (position == 1)
            {
                numbers.Add(0);
            }
            

            //numbercircles\\
            number = r.Next(2, 13);

            //Make sure all numbers are assigned and 6 and 8 are not next to eachother\\
            while ((number == 7) || (number == 2 && two == 0) || (number == 3 && three == 0) || (number == 4 && four == 0) || (number == 5 && five == 0) || (number == 6 && six == 0) || (number == 8 && eight == 0) || (number == 9 && nine == 0) || (number == 10 && ten == 0) || (number == 11 && eleven == 0) || (number == 12 && twelve == 0) || ((number == 6 || number == 8) && (lastnumber == 6 || lastnumber == 8))|| (position == 4 && (number == 6 || number == 8) && (numbers[1] == 6 || numbers[1] == 8))|| (position == 5 && (number == 6 || number == 8) && ((numbers[1] == 6 || numbers[1] == 8) || (numbers[2] == 6 || numbers[2] == 8)))|| (position == 6 && (number == 6 || number == 8) && ((numbers[2] == 6 || numbers[2] == 8) || (numbers[3] == 6 || numbers[3] == 8)))|| (position == 7 && (number == 6 || number == 8) && (numbers[3] == 6 || numbers[3] == 8))|| (position == 8 && (number == 6 || number == 8) && (numbers[4] == 6 || numbers[4] == 8))|| (position == 9 && (number == 6 || number == 8) && ((numbers[4] == 6 || numbers[4] == 8) || (numbers[5] == 6 || numbers[5] == 8)))|| (position == 10 && (number == 6 || number == 8) && ((numbers[5] == 6 || numbers[5] == 8) || (numbers[6] == 6 || numbers[6] == 8)))|| (position == 11 && (number == 6 || number == 8) && ((numbers[6] == 6 || numbers[6] == 8) || (numbers[7] == 6 || numbers[7] == 8)))|| (position == 12 && (number == 6 || number == 8) && (numbers[7] == 6 || numbers[7] == 8))|| (position == 13 && (number == 6 || number == 8) && ((numbers[8] == 6 || numbers[8] == 8) || (numbers[9] == 6 || numbers[9] == 8)))|| (position == 14 && (number == 6 || number == 8) && ((numbers[9] == 6 || numbers[9] == 8) || (numbers[10] == 6 || numbers[10] == 8)))|| (position == 15 && (number == 6 || number == 8) && ((numbers[10] == 6 || numbers[10] == 8) || (numbers[11] == 6 || numbers[11] == 8)))|| (position == 16 && (number == 6 || number == 8) && ((numbers[11] == 6 || numbers[11] == 8) || (numbers[12] == 6 || numbers[12] == 8)))|| (position == 17 && (number == 6 || number == 8) && ((numbers[13] == 6 || numbers[13] == 8) || (numbers[14] == 6 || numbers[14] == 8)))|| (position == 18 && (number == 6 || number == 8) && ((numbers[14] == 6 || numbers[14] == 8) || (numbers[15] == 6 || numbers[15] == 8)))|| (position == 19 && (number == 6 || number == 8) && ((numbers[15] == 6 || numbers[15] == 8) || (numbers[16] == 6 || numbers[16] == 8))))
            {
                number = r.Next(2, 13);
                if (two == 0 &&  three == 0 &&  four == 0 && five == 0 && six == 0 && eight == 0 && nine == 0 && ten == 0 && eleven == 0 && twelve == 0)
                {
                    break;
                }
            }

            //while ((position == 4 && (number == 6|| number == 8) && (numbers[1] == 6 || numbers[1] == 8)))

            

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
            lastnumber = number;
            numbers.Add(number);
            position++;
        }          
    }
}