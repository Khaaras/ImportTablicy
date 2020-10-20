using System;
using System.Drawing;

namespace _1_Tablica
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] monthsOfYear =
            {
                "January",
                "February",
                "March",
                "April", 
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December",
            };

            Console.WriteLine("Which month do you want to display?");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(monthsOfYear[a-1]);

            //int[] arrayInt = { 4, 7, 44, 77 };

            //char[] arrayChar = { 'h', 'a', 'y', '6' };

            //System.Drawing.Rectangle[] arrayRectangle =
            //{
            //    new System.Drawing.Rectangle(10, 10, 50, 50),
            //    new System.Drawing.Rectangle(30, 30, 50, 50),
            //    new System.Drawing.Rectangle(20, 100, 100, 50)
            //};

            //foreach (var month in monthsOfYear)
            //{
            //    Console.WriteLine(month);

            //}
        }
    }
}
