using UniversityManagementSystem.Repositories;
using UniversityManagementSystem.BusinessLogic.DTO;
using UniversityManagementSystem.BusinessLogic.Services;
using System;
using static UniversityManagementSystem.DataAccess.Models.Enums.EnumDefinitions;
using UniversityManagementSystem.Models;

namespace UniversityManagementSystem.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentDataPath = "studentsData.json";

            StudentRepository studentRepository = new StudentRepository(studentDataPath);

            StudentService studentService = new StudentService(studentRepository);

            StudentsController studentController = new StudentsController(studentService);

            StudentUI studentUI = new StudentUI(studentController);

            while (true)
            {
                studentUI.DisplayOption();
            }

            // Adding students

        }
    }
}
