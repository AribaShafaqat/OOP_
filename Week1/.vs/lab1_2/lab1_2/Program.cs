using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string day, month;
            int total;
            Console.WriteLine("Enter day: ");
            day=Console.ReadLine();
            Console.WriteLine("Enter Month:");
            month=Console.ReadLine();
            Console.WriteLine("Enter total:");
            total=int.Parse(Console.ReadLine());
            int store;
            store=dis(day, month, total);
            Console.WriteLine(store);
            Console.ReadKey();

        }
        static int dis(string day,string month,int total)
        {
            int discount;
            if (day=="Sunday" && month=="October")
            {
                discount=(int)(total-total*0.5);
            }
            else
            {
                discount=total;
            }
            return discount;
        }
    }
}
