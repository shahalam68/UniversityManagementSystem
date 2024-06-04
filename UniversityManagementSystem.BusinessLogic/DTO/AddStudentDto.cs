
using static UniversityManagementSystem.DataAccess.Models.Enums.EnumDefinitions;

namespace UniversityManagementSystem.BusinessLogic.DTO
{
    public class AddStudentDto
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string StudentId { get; set; }
        public Department Department { get; set; }
        public Degree Degree { get; set; }
    }
}
