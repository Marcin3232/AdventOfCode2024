using System.ComponentModel;

namespace Common.Utils;

public static class EnumHelper
{
    public static string GetEnumDescription(Enum value)
    {
        var field = value.GetType().GetField(value.ToString());
        var attribute = (DescriptionAttribute?)field?.GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault();
        return attribute?.Description ?? value.ToString();
    }
}
