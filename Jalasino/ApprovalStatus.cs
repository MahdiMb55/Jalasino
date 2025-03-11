using Jalasino;
using System.ComponentModel;
using System.Reflection;

namespace Jalasino
{
    public enum ApprovalStatus
    {
        [Description("نامشخص")]
        None,

        [Description("تأیید شده")]
        Confirmed,

        [Description("ثبت شده")]
        Registered,

        [Description("کامل شده")]
        Complete,

        [Description("ناکامل")]
        InComplete
    }
}

public static class ApprovalStatusExtensions
{
    public static string GetDescription(this ApprovalStatus status)
    {
        FieldInfo field = typeof(ApprovalStatus).GetField(status.ToString());
        DescriptionAttribute attribute = field.GetCustomAttribute<DescriptionAttribute>();

        return attribute?.Description ?? status.ToString();
    }
}