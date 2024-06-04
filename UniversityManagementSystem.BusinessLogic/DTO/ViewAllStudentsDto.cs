using static UniversityManagementSystem.DataAccess.Models.Enums.EnumDefinitions;

namespace UniversityManagementSystem.BusinessLogic.DTO
{
    public class ViewAllStudentsDto
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string StudentId { get; set; }
        public string Department { get; set; }
        public string Degree { get; set; }

        public override string ToString()
        {
            return $"FirstName: {FirstName},MiddleName: {MiddleName},LastName:{LastName}, Id: {StudentId}, Degree: {Degree}, Department: {Department}";
        }
    }
}
