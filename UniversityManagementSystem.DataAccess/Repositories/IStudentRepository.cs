using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementSystem.DataAccess.Models;

namespace UniversityManagementSystem.DataAccess.Repositories
{
    public interface IStudentRepository
    {
        void AddStudent(Student student);


        Student GetStudentById(string studentId);


        List<Student> GetAllStudents();


        void RemoveStudent(Student student);


        //private void SaveChanges();
        
    }
}
