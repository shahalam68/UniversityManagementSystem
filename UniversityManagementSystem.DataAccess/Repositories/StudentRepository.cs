using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UniversityManagementSystem.DataAccess.Models;
using UniversityManagementSystem.DataAccess.Repositories;

namespace UniversityManagementSystem.Repositories
{
    public class StudentRepository:IStudentRepository
    {
        
       // private List<Student> _students;

        private readonly string _jsonFilePath;

        public StudentRepository(string filePath)
        {
            _jsonFilePath = filePath;
        }

        public void AddStudent(Student student)
        {
            List<Student> students = GetAllStudents();

            students.Add(student);

            string jsonData = ToJson(students);

            File.WriteAllText(_jsonFilePath, jsonData);
        }

        public Student GetStudentById(string studentId)
        {
            List<Student> students = GetAllStudents();
            return students.FirstOrDefault(s => s.StudentId == studentId);

            //return _students.Find(s => s.StudentId == studentId);
        }

        public List<Student> GetAllStudents()
        {
            string jsonData = File.ReadAllText(_jsonFilePath);
            return FromJson<List<Student>>(jsonData) ?? new List<Student>();
            //return _students;
        }

        public void RemoveStudent(Student student)
        {
            List<Student> students = GetAllStudents();
            students.RemoveAll(s => s.StudentId == student.StudentId);

            string jsonData = ToJson(students);
            File.WriteAllText(_jsonFilePath, jsonData);
        }

        public static string ToJson(object obj)
        {
            return JsonConvert.SerializeObject(obj, Formatting.Indented);
        }

        //Deserialize
        public static T FromJson<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}