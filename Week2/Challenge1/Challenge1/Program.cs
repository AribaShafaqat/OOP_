using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    internal class Program
    {
        class Product
        {
           public int productID;
           public string name;
           public int price;
           public string BrandName;
           public string Country;
           public char Category;

        }
        static char menu()
        {
            char choice;
            Console.Clear();
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Show Product");
            Console.WriteLine("3. Total Store Width");
            choice=char.Parse(Console.ReadLine());
            return choice;

        }
        static Product addProduct()
        {
            Console.Clear();
            Product p1 = new Product();
            Console.WriteLine("Enter Product ID:");
            p1.productID=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product Name:");
            p1.name=Console.ReadLine();
            Console.WriteLine("Enter Product Price:");
            p1.price=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Brand Name:");
            p1.BrandName=Console.ReadLine();
            Console.WriteLine("Enter Country:");
            p1.Country=Console.ReadLine();
            Console.WriteLine("Enter Category:");
            p1.Category=char.Parse(Console.ReadLine());
            return p1;
        }
        
        static void viewProduct(Product[] p , int count)
        {
            Console.Clear();
            for(int i=0;i<count;i++)
            {
                Console.WriteLine("ID: {0} Name: {1} Price: {2} Brand:{3} Country: {4} Category:{5}", p[i].productID, p[i].name, p[i].price, p[i].BrandName, p[i].Country, p[i].Category);

            }
            Console.WriteLine("Press Any Key To Continue..");
            Console.ReadKey();
        }
        static void StoreWidth(Product[] p,int count)
        {
            Console.Clear();
            int store=0;
            if (count==0)
            {
                Console.WriteLine("No Reacord Exists.");
            }
            else
            {
                for (int i = 0; i<count; i++)
                {
                    store=store+p[i].price;
                }
            }
            Console.WriteLine(store);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Product[] p = new Product[10];
            char option;
            int count = 0;
            do
            {
                option=menu();
                if (option=='1')
                {
                    p[count]=addProduct();
                    count++;
                }
                else if (option=='2')
                {
                    viewProduct(p, count);
                }
                else if (option=='3')
                {
                    StoreWidth(p, count);
                }
                else if (option=='4')
                {
                    break;
                }
                else
                {
                    Console.WriteLine( "Invalid Choice.");
                }
            }
            while (option!='4');
            Console.WriteLine("Press Enter to Exist..");
            Console.ReadKey();
        }
    }
}
