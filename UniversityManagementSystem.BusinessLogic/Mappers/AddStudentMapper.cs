using UniversityManagementSystem.Models;
using UniversityManagementSystem.BusinessLogic.DTO;
using UniversityManagementSystem.DataAccess.Models;

namespace UniversityManagementSystem.BusinessLogic.Mappers
{
    public static class AddStudentMapper
    {
        public static AddStudentDto MapToDTO(Student student)
        {
            return new AddStudentDto
            {
                FirstName = student.FirstName,
                MiddleName = student.MiddleName,
                LastName = student.LastName,
                StudentId = student.StudentId,
                Department = student.Department,
                Degree = student.Degree
            };
        }

        public static Student MapToEntity(AddStudentDto studentDto)
        {
            return new Student
            {
                FirstName = studentDto.FirstName,
                MiddleName = studentDto.MiddleName,
                LastName = studentDto.LastName,
                StudentId = studentDto.StudentId,
                Department = studentDto.Department,
                Degree = studentDto.Degree
            };
        }
    }
}
