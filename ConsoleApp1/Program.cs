using ClassFizzbuzz;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Fizzbuzz FF = new Fizzbuzz(); //สร้างออบเจ็กต์ของ Fizzbuzz
            
            for (int i = 1; i < int.Parse(args[0]); i++)
            {
                Console.WriteLine(FF.FindFizzbuzz(i)); //แสดงค่าของFF โดยที่ดึงค่าi จาก Fizzbuzz.csมาแสดงผล
            }
            Console.ReadLine();
        }


    }
}
