using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    internal class Program
    {
        class student
        {
            public string name;
            public int Roll_no;
            public float cgpa;
            public char isHostelide;
            public string Department;
        }
        static char menu()
        {
            Console.Clear();
            char choice;
            Console.WriteLine("1: Add a student");
            Console.WriteLine("2: View a student");
            Console.WriteLine("3: Top 3 students");
            Console.WriteLine("4. Exit");
            choice=char.Parse(Console.ReadLine());
            return choice;
        }
        static student addStudent()
        {
            Console.Clear();
            student s1 = new student();
            Console.WriteLine("Enter Name:");
            s1.name=Console.ReadLine();
            Console.WriteLine("Enter Roll Number:");
            s1.Roll_no=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter CGPA:");
            s1.cgpa=float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Department:");
            s1.Department=Console.ReadLine();
            Console.WriteLine("Is Hostelide (y||n):");
            s1.isHostelide=char.Parse(Console.ReadLine());
            return s1;
        }
        static void viewStudent(student[] s, int count)
        {
            Console.Clear();
            for (int i = 0; i<count; i++)
            {
                Console.WriteLine("Name: {0} Roll No: {1} CGPA: {2} Department: {3} IsHostelide: {4}", s[i].name, s[i].Roll_no, s[i].cgpa, s[i].Department, s[i].isHostelide);
            }
            Console.WriteLine("Press any Key to Continue..");
            Console.ReadKey();
        }
        static void topStudent(student[] s, int count)
        {
            Console.Clear();
            if (count==0)
            {
                Console.WriteLine("No Record Present");
            }
            else if (count==1)
            {
                viewStudent(s, 1);
            }
            else if (count==2)
            {
                for (int x = 0; x<2; x++)
                {
                    int idx = largest(s, x, count);
                    student temp = s[idx];
                    s[idx]=s[x];
                    s[x]=temp;

                }
                viewStudent(s, 2);
            }
            else
            {
                for (int x = 0; x<3; x++)
                {
                    int idx = largest(s, x, count);
                    student temp = s[idx];
                    s[idx]=s[x];
                    s[x]=temp;

                }
                viewStudent(s, 3);
            }
        }
        static int largest(student[] s, int start, int end)
        {
            int idx = start;
            float large = s[start].cgpa;
            for (int x = start; x<end; x++)
            {
                if (large<s[x].cgpa)
                {
                    large=s[x].cgpa;
                    idx=x;
                }
            }
            return idx;
        }

        static void Main(string[] args)
        {
            student[] s = new student[10];
            char option;
            int count = 0;
            do
            {
                option=menu();
                if (option=='1')
                {
                    s[count]=addStudent();
                    count++;
                }
                else if (option =='2')
                {
                    viewStudent(s, count);
                }
                else if (option=='3')
                {
                    topStudent(s, count);
                }
                else if (option=='4')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("invalid Choice");
                }
            } while (option!='4');
            Console.WriteLine("Please Enter to Exit..");
            Console.ReadKey();
            
        }
    }
}
