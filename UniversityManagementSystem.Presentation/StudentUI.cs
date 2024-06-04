using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem.Presentation
{
    public class StudentUI
    {
        public delegate void ShowOptionDelegate(string message); // Show Option delegate
        public delegate string Greetings(); //Show Greeting Message Delegate

        private readonly StudentsController _studentController;

        public StudentUI(StudentsController studentController)
        {
            _studentController = studentController;
        }

        public static void ShowOption(string option)
        {
            Console.WriteLine(option);
        }


        public static void Show(ShowOptionDelegate showDelegate, params string[] options)
        {
            foreach (string option in options)
                showDelegate(option);
        }


        //Display Menu Method
        public void DisplayOption()
        {
            //Anonymous Greetings Method
            Greetings greetings = delegate ()
            {
                return "\nWelcome to Student Management System";
            };

            string WelcomeMessage = greetings.Invoke();

            Console.WriteLine(WelcomeMessage);
            Console.WriteLine();

            ShowOptionDelegate optionDelegate = ShowOption;

            Show(optionDelegate, "1. Display All Studnets", "2. View Student", "3. Add New Student", "4. Delete Student", "5. Exit (press 6 to exit)");


            Console.WriteLine();

            string? choice = Console.ReadLine();

            HandleUserInput(choice);
        }


        //Process User Choice
        private void HandleUserInput(string choice)
        {
            switch (choice)
            {
                case "1":
                    _studentController.ViewAllStudents();
                    break;
                case "2":
                    _studentController.ViewStudentDetails();
                    break;
                case "3":
                    _studentController.AddStudent();
                    break;
                case "4":
                    _studentController.DeleteStudent();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
