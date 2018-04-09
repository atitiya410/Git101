using System;
using System.Collections.Generic;
using System.Text;

namespace ClassFizzbuzz
{
    public class Fizzbuzz //ชื่อclassFizzbuzz
    {
        public string FindFizzbuzz(int i) //สร้างเพื่อเรียกใช้Method toString() โดยมี i ประกาศเป็นint 
        {
            if (((i % 3) == 0) && ((i % 5) == 0))
            {
                return "fizzbuzz";
            }
            else if ((i % 3) == 0)
            {
                return "fizz";
            }
            else if ((i % 5) == 0)
            {
                return "buzz";

            }
            else
            {
                return " " + i;
            }
        }
    }
}
