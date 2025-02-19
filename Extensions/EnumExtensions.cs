using System;
using TextFileProcessing.Attributes;

namespace TextFileProcessing.Extensions
{
	public static class EnumExtensions
	{
		public static string GetName(this Enum value)
		{
			var type = value.GetType();
			var memberInfo = type.GetMember(value.ToString());
			var attributes = memberInfo[0].GetCustomAttributes(typeof(NameAttribute), false);

			return attributes.Length > 0 ? ((NameAttribute)attributes[0]).Name : value.ToString();
		}
	}
}
