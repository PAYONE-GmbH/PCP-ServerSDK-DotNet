namespace PCPServerSDKDotNet.Utils;

using System.Reflection;
using System.Runtime.Serialization;

internal static class EnumExtensions
{
    internal static string GetWireValue<T>(this T value)
        where T : struct, Enum
    {
        MemberInfo member = typeof(T).GetMember(value.ToString())[0];
        EnumMemberAttribute? attribute = member.GetCustomAttribute<EnumMemberAttribute>();
        return attribute?.Value ?? value.ToString();
    }
}
