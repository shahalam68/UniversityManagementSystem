
using UniversityManagementSystem.BusinessLogic.DTO;
using UniversityManagementSystem.BusinessLogic.Mappers;
using UniversityManagementSystem.BusinessLogic.Interfaces;
using System.Collections.Generic;
using System.Linq;
using UniversityManagementSystem.Repositories;

namespace UniversityManagementSystem.BusinessLogic.Services
{
    public class StudentService : IStudentService
    {
        private readonly StudentRepository _studentRepository;

        public StudentService(StudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void AddStudent(AddStudentDto studentDto)
        {
            var student = AddStudentMapper.MapToEntity(studentDto);
            _studentRepository.AddStudent(student);
        }

        public ViewStudentDto GetStudentById(string studentId)
        {
            var student = _studentRepository.GetStudentById(studentId);
            return student != null ? ViewStudentMapper.MapToDTO(student) : null;
        }

        public List<ViewAllStudentsDto> GetAllStudents()
        {
            var students = _studentRepository.GetAllStudents();
            return students.Select(ViewAllStudentsMapper.MapToDTO).ToList();
        }

        public void RemoveStudent(ViewStudentDto studentDto)
        {
            var student = _studentRepository.GetStudentById(studentDto.StudentId);
            if (student != null)
            {
                _studentRepository.RemoveStudent(student);
            }
        }
    }
}
