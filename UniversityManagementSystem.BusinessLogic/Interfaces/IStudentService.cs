using UniversityManagementSystem.BusinessLogic.DTO;
using UniversityManagementSystem.Models;
using System.Collections.Generic;

namespace UniversityManagementSystem.BusinessLogic.Interfaces
{
    public interface IStudentService
    {
        void AddStudent(AddStudentDto studentDto);
        ViewStudentDto GetStudentById(string studentId);
        List<ViewAllStudentsDto> GetAllStudents();
        void RemoveStudent(ViewStudentDto studentDto);
    }
}
