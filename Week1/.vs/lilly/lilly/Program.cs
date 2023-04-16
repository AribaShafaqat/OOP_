using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lilly
{
    internal class Program
    {
        static void Main(string[] args)
        {
          float age;
            float WashingPrice;
            float toyPrice;
            Console.WriteLine("Enter Age Of Lilly:");
            age=float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Price Of Washing Machine:");
            WashingPrice=float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Price Of Toy:");
            toyPrice=float.Parse(Console.ReadLine());
            float price = calculate(age, WashingPrice, toyPrice);
            Console.WriteLine(price);
            Console.ReadKey();

        }
        static float calculate(float age,float WashingPrice,float toyPrice)
        {
            float toy = 0;
            float money = 0;
            float saved;
            float sum = 0;
            float remaining=0 ;
            for(int counter=2;counter<=age;counter+=2)
            {
                money=money+10;
                saved=money-1;
                sum=sum+saved;
            }
            for(int counter=1;counter<=age;counter+=2)
            {
                toy=toy+toyPrice;
            }
            float Total = sum+toy;
            if(Total>WashingPrice)
            {
                remaining=Total-WashingPrice;
               
            }
            else if(Total<WashingPrice)
            {
                remaining=WashingPrice-Total;
               
            }
            return remaining;


        }
    }
}
