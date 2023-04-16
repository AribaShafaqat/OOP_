using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2
{
    internal class Program
    {
        class students
        {
            public string name;
            public int roll_no;
            public float cgpa;
        }
        static void Main(string[] args)
        {
            students s1 = new students();
            Console.WriteLine("Enter Name:");
            s1.name=Console.ReadLine();
            Console.WriteLine("Enter Roll Number:");
            s1.roll_no=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter CGPA:");
            s1.cgpa=float.Parse(Console.ReadLine());

            Console.WriteLine("Name:{0} Roll No: {1} CGPA: {2}", s1.name, s1.roll_no, s1.cgpa);
            

            Console.ReadKey();

        }
    }
}
