using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace UniversityManagementSystem.BusinessLogic.Utilities
{
    public static class EnumExtensions
    {
        public static string GetDescription(this Enum enumValue)
        {
            return enumValue.GetType()
                            .GetMember(enumValue.ToString())
                            .FirstOrDefault()?
                            .GetCustomAttribute<DescriptionAttribute>()?
                            .Description ?? enumValue.ToString();
        }
    }
}
