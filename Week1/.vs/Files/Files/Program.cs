using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Writing();
           
        }
        static void reading()
        {
            // READING FROM A FILE
            string path = "C:\\Users\\dell\\Documents\\OOP\\Week1\\std.txt";
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record=fileVariable.ReadLine())!=null)
                {
                    Console.WriteLine(record);
                }
                fileVariable.Close();
            }
            else
            {
                Console.WriteLine("Not Exists");
            }
            Console.ReadKey();
        }
        static void Writing()
        {
            string path = "C:\\Users\\dell\\Documents\\OOP\\Week1\\std.txt";
            StreamWriter fileVariable = new StreamWriter(path, true);
            fileVariable.WriteLine("I am Ariba, Cs Student");
            fileVariable.Flush();
            fileVariable.Close();
        }
    }
}
