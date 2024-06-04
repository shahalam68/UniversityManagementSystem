using System.ComponentModel;

namespace UniversityManagementSystem.DataAccess.Models.Enums
{
    public class EnumDefinitions
    {
        public enum Department
        {
            [Description("Computer Science Engineering")]
            CSE,
            [Description("Bachelor of Business Administration")]
            BBA,
            [Description("English")]
            ME
        }

        public enum Degree
        
        {   
            [Description("Bachelor Of Science")]
            BSC,
            [Description("Bachelor of Arts")]
            BA,
            [Description("Master of business administration")]
            MBA
        }
    }
}
