using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static UniversityManagementSystem.DataAccess.Models.Enums.EnumDefinitions;
using UniversityManagementSystem.BusinessLogic.Services;
using UniversityManagementSystem.DataAccess.Models;
using UniversityManagementSystem.BusinessLogic.DTO;

namespace UniversityManagementSystem.Presentation
{
    

    public class StudentsController
    {
        private readonly StudentService _studentService;


        public StudentsController(StudentService studentService)
        {
            _studentService = studentService;
            
        }

        //View All Student
        public void ViewAllStudents()
        {
            List<ViewAllStudentsDto> students = _studentService.GetAllStudents();

            if (students.Count == 0)
            {
               
                Console.WriteLine ("\nThere are currently no student\n");
            }
            else
            {
                Console.WriteLine("\nAll students List: \n");

                foreach (ViewAllStudentsDto student in students)
                {
                    Console.WriteLine(student.ToString());
                }
            }
        }

        //View Student By ID
        public void ViewStudentDetails()
        {
            try
            {
                Console.Write("Enter Student ID: ");

                string? studentId = Console.ReadLine();

                var student = _studentService.GetStudentById(studentId);

                if (student != null)
                {

                    Console.WriteLine("\nStudent Details:\n");
                    Console.WriteLine($"Name: {student.FirstName} {student.MiddleName} {student.LastName}");
                    Console.WriteLine($"Student ID: {student.StudentId}");
                    Console.WriteLine($"Department: {student.Department}");
                    Console.WriteLine($"Degree: {student.Degree}");

                   

                    
                }
                else
                {
                    Console.WriteLine($"\nStudent with ID {studentId} not found.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        //Add Student
        public void AddStudent()
        {
            try
            {
                Console.Write("First Name : ");
                dynamic? firstName = Console.ReadLine();

                Console.Write("Middle Name : ");
                dynamic? middleName = Console.ReadLine();

                Console.Write("Last Name : ");
                dynamic? lastName = Console.ReadLine();

           
                Console.Write("Student ID (format XXX-XXX-XXX) : ");
                dynamic? studentID = Console.ReadLine();

            
                Console.Write("Department Number (0 for CSE , 1 for BBA, 2 for English) : ");
                int department = Convert.ToInt32(Console.ReadLine());

                

            
                Console.Write("Degree Number (0 for BSC, 1 for BA, 2 for MBA, ): ");
                int degree = Convert.ToInt32(Console.ReadLine());

               AddStudentDto studentDTO = new AddStudentDto
               {
                   FirstName = firstName,
                   MiddleName = middleName,
                   LastName = lastName,
                   StudentId = studentID,
                   Department = (Department)department,
                   Degree = (Degree) degree
               };

                _studentService.AddStudent(studentDTO);

                Console.WriteLine("\nStudent Added Successfully\n");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        
        //Delete Student 
        public void DeleteStudent()
        {
            try
            {
                Console.Write("Enter Student ID: ");

                string? studentId = Console.ReadLine();

                var student = _studentService.GetStudentById(studentId);

                if (student != null)
                {
                    _studentService.RemoveStudent(student);
                    Console.WriteLine("\nStudent Deleted Successfully\n");
                }
                else
                {
                    Console.WriteLine($"\nStudent with ID {studentId} not found.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
