using System;
using System.Collections.Generic;
using System.Text;

namespace TTHK
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Teachers> Teachers = new List<Teachers>();

            Console.WriteLine("Please enter the teachers first name!");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter the teachers last name!");
            string lastName = Console.ReadLine();

            Console.WriteLine("Please enter the teachers personal code!");
            string personalCode = Console.ReadLine();

            Console.WriteLine("Is the teacher full time: Y/N");
            string isFullTime = Console.ReadLine();

            Teachers teacher = new Teachers(firstName, lastName, personalCode, isFullTime);
            Teachers.Add(teacher);

            while (true)
            {
                string userInput = Console.ReadLine();
                if(userInput == "N")
                { 
                Console.WriteLine("What is the name of their course?");
                string courseName = Console.ReadLine();

                Console.WriteLine("What is the duration of that course?");
                int Duration = int.Parse(Console.ReadLine());
                Course course = new Course(courseName, Duration);

                teacher.AddCourses(course);
                Console.WriteLine("Is that all? Y/N");
                }

                else
                {
                    break;
                }



            }
            Console.WriteLine(teacher);
        }
            
             


               
     }
            


           


           
  }
    

