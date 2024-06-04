using UniversityManagementSystem.BusinessLogic.DTO;
using UniversityManagementSystem.BusinessLogic.Utilities;
using UniversityManagementSystem.DataAccess.Models;

namespace UniversityManagementSystem.BusinessLogic.Mappers
{
    public static class ViewAllStudentsMapper
    {
        public static List<ViewAllStudentsDto> MapToViewAllStudentsDto(List<Student> students)
        {
            var result = new List<ViewAllStudentsDto>();
            foreach (var student in students)
            {
                result.Add(new ViewAllStudentsDto
                {
                    FirstName = student.FirstName,
                    MiddleName = student.MiddleName,
                    LastName = student.LastName,
                    StudentId = student.StudentId,
                    Department = student.Department.GetDescription(),
                    Degree = student.Degree.GetDescription()
                });
            }
            return result;
        }

        public static ViewAllStudentsDto MapToDTO(Student student)
        {
            return new ViewAllStudentsDto
            {
                FirstName = student.FirstName,
                MiddleName = student.MiddleName,
                LastName = student.LastName,
                StudentId = student.StudentId,
                Department = student.Department.GetDescription(),
                Degree = student.Degree.GetDescription()
            };
        }
    }
}
