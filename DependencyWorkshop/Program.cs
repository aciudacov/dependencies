using BusinessLogic.Students;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyWorkshop
{
    class Program
    {
        //Program that takes some input and saves it to a medium (start of in memory, then save to disk, in a file)
        //Make a simple command line interpreter: ex: ADD_STUDENT Alex
        //Save it to a collection
        //Print out what we have inside the collection
        static void Main(string[] args)
        {
            IStudentDataAccess studentRepository = new StudentDataAccess();
            IStudentBusinessLogic _studentLogic = new StudentBusinessLogic(studentRepository);


            string command = "";
            while (command != "EXIT")
            {
                Console.WriteLine("Input a command please...");

                command = Console.ReadLine();
                //maybe validate the command line
                string[] commandArguments = command.Split(' ');

                switch (commandArguments[0])
                {
                    case "ADD_STUDENT":
                        _studentLogic.AddStudent(commandArguments[1]);
                        break;
                    case "LIST_STUDENTS":
                        _studentLogic.ListStudents();
                        break;
                    case "EXIT":
                        break;
                    default:
                        Console.WriteLine("Unknown command!");
                        break;
                }

                Console.WriteLine(_studentLogic.BadMethodWhichDoMillionOfThings(commandArguments[1]));
            }

            Console.WriteLine("Done!");
            Console.ReadKey();
        }
    }
}
