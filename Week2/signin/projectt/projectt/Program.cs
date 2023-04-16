using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectt
{
    internal class Program
    {
        class Credential
        {
            public string name;
            public string password;

            static void Main(string[] args)
            {
                List<Credential> users = new List<Credential>();
                string path = "C:\\Users\\dell\\Documents\\OOP\\pd 2\\projectt\\file.txt.txt";
                int option;
                do
                {
                    readData(path, users);
                    Console.Clear();
                    option = menu();
                    Console.Clear();
                    if (option == 1)
                    {
                        Console.WriteLine("Enter Name: ");
                        string n = Console.ReadLine();
                        Console.WriteLine("Enter Password: ");
                        string p = Console.ReadLine();
                        signIn(n, p, users);
                    }
                    else if (option == 2)
                    {
                        Console.WriteLine("Enter New Name: ");
                        string n = Console.ReadLine();
                        Console.WriteLine("Enter New Password: ");
                        string p = Console.ReadLine();
                        signUp(path, n, p);
                    }
                }
                while (option < 3);
                Console.Read();
            }
        }
        static int menu()
        {
            int option;
            Console.WriteLine("1. SignIn");
            Console.WriteLine("2. SignUp");
            Console.WriteLine("Enter Option");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        static void readData(string path, List<Credential> users)
        {
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    Credential info = new Credential();
                    info.name = parseData(record, 1);
                    info.password = parseData(record, 2);
                    users.Add(info);
                }
                fileVariable.Close();
            }
            else
            {
                Console.WriteLine("Not Exists");
            }
        }
        static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
        static void signIn(string n, string p, List<Credential> users)
        {
            bool flag = false;
            for (int x = 0; x < users.Count; x++)
            {
                if (n == users[x].name && p == users[x].password)
                {
                    Console.WriteLine("Valid User");
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("Invalid User");
            }
            Console.ReadKey();
        }
        static void signUp(string path, string n, string p)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(n + "," + p);
            file.Flush();
            file.Close();
        }



    }
}

