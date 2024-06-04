using System;
using UniversityManagementSystem.BusinessLogic.DTO;
using UniversityManagementSystem.DataAccess.Models;
using UniversityManagementSystem.BusinessLogic.Utilities;
using UniversityManagementSystem.Models;

namespace UniversityManagementSystem.BusinessLogic.Mappers
{
    public static class ViewStudentMapper
    {
        public static ViewStudentDto MapToViewStudentDto(Student student)
        {
            return new ViewStudentDto
            {
                FirstName = student.FirstName,
                MiddleName = student.MiddleName,
                LastName = student.LastName,
                StudentId = student.StudentId,
                Department = student.Department.GetDescription(),
                Degree = student.Degree.GetDescription(),
            };
        }

        public static ViewStudentDto MapToDTO(Student student)
        {
            return new ViewStudentDto
            {
                FirstName = student.FirstName,
                MiddleName = student.MiddleName,
                LastName = student.LastName,
                StudentId = student.StudentId,
                Department = student.Department.GetDescription(),
                Degree = student.Degree.GetDescription(),
            };
        }

        internal static Student MapToEntity(ViewStudentDto studentDto)
        {
            throw new NotImplementedException();
        }
    }
}
