using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exp1();
            //task1();
            task2();
        }
        static void exp1()
        {
            string str;
            Console.WriteLine("You Have Inputted:");
            str=Console.ReadLine();
            float num = float.Parse(str);
            Console.WriteLine("Floating Value is:");
            Console.Write(num);
            Console.ReadKey();
        }
        static void task1()
        {
            int length;
            int area;
            Console.WriteLine("Enter Value Of Length:");
            length=int.Parse(Console.ReadLine());
            area=length*length;
            Console.WriteLine("Area Of Square Is:");
            Console.Write(area);
            Console.ReadKey();

        }
        static void task2()
        {
            int marks;
            Console.WriteLine("Enter Your Marks:");
            marks=int.Parse(Console.ReadLine());
            if(marks>50)
            {
                Console.WriteLine("You are passed!");
            }
            else
            {
                Console.WriteLine("You are Failed!");
            }
            Console.ReadKey();
        }
       


        
    }
}
