using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Challenge2
{
    internal class Program
    {
        class data
        {
            public string name;
            public string password;

            static char menu()
            {
                Console.Clear();
                char option;
                Console.WriteLine("1. Sign In:");
                Console.WriteLine("2. Sign Up:");
                Console.WriteLine("Enter Option..");
                option=char.Parse(Console.ReadLine());
                return option;

            }
            static void Main(string[] args)
            {
                int count = 0;
                string path = "C:\\Users\\dell\\Documents\\OOP\\Week2\\Challenge2\\data.txt.txt";
                data[] d = new data[5];
                Console.Clear();
                char option;
                Console.Clear();
                do
                {
                    readData(path, d);
                     option = menu();
                    if (option=='1')
                    {
                        data d1 = new data();
                        Console.WriteLine("Enter Name:");
                        string n = Console.ReadLine();
                        Console.WriteLine("Enter Password:");
                        string p = Console.ReadLine();
                        signIn(n, p, d, count);

                    }
                    if (option=='2')
                    {
                        d[count]=adduser();
                        count=count+1;
                        signUp(path, d, count);
                    }

                } while (option<'3');

                Console.ReadKey();


            }
            static string parseData(string record, int field)
            {
                int comma = 1;
                string item = "";
                for (int x = 0; x<record.Length; x++)
                {
                    if (record[x]==',')
                    {
                        comma++;
                    }
                    else if (comma==field)
                    {
                        item=item+record[x];
                    }
                }
                return item;
            }
            static void readData(string path, data[] d)
            {
                int x = 0;
                if (File.Exists(path))
                {
                    StreamReader fileVariable = new StreamReader(path);
                    string record;
                    while ((record=fileVariable.ReadLine())!=null)
                    {
                        data d1 = new data();
                        d1.name=parseData(record, 1);
                        d1.password=parseData(record, 2);
                       // x++;
                        d[x++]=d1;
                       
                    }
                    fileVariable.Close();

                }
                else
                {
                    Console.WriteLine("Not Exists");
                }
            }
            static void signIn(string n, string p, data[] d, int count)
            {
                bool flag = false;
                for (int x = 0; x<count; x++)
                {
                    if (n == d[x].name && p==d[x].password)
                    {
                        Console.WriteLine("Valid User");
                        flag=true;
                    }
                }
                if (flag==false)
                {
                    Console.WriteLine("Invalid User");
                }
                Console.ReadKey();
            }
            static data adduser()
            {
                data d1 = new data();
                Console.WriteLine("Enter New Name:");
                d1.name=Console.ReadLine();
                Console.WriteLine("Enter New Password:");
                d1.password=Console.ReadLine();
                return d1;
            }
            static void signUp(string path, data[] d1,int count)
            {
                StreamWriter file = new StreamWriter(path, false);
                for (int x = 0; x<count; x++)
                {
                    file.WriteLine(d1[x].name+ "," + d1[x].password);
                    
                }
                file.Flush();
                file.Close();

            }


        }
    }
}



