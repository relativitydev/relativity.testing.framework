using Relativity.Testing.Framework.Attributes;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Defines the different values for the type of the value for the instance setting.
	/// </summary>
	public enum InstanceSettingValueType
	{
		/// <summary>
		/// Indicates the default value type. By default it is text.
		/// </summary>
		Default = 0,

		/// <summary>
		/// Indicates that the value should be treated as text.
		/// </summary>
		[ChoiceName("Text")]
		Text = 1,

		/// <summary>
		/// Indicates that the value be treated as a whole number from -2147483648 to 2147483647.
		/// </summary>
		[ChoiceName("Integer 32-bit")]
		Integer32 = 2,

		/// <summary>
		/// Indicates that the value should be treated as a whole number from -9223372036854775808 to 9223372036854775807.
		/// </summary>
		[ChoiceName("Integer 64-bit")]
		Integer64 = 3,

		/// <summary>
		/// Indicates that the value should be treated as a whole number from 0 to 2147483647.
		/// </summary>
		[ChoiceName("Nonnegative Integer 32-bit")]
		NonnegativeInt32 = 4,

		/// <summary>
		/// Indicates that the value should be treated as a whole number from 0 to 9223372036854775807.
		/// </summary>
		[ChoiceName("Nonnegative Integer 64-bit")]
		NonnegativeInt64 = 5,

		/// <summary>
		/// Indicates that the value should be treated as a whole number from 1 to 2147483647.
		/// </summary>
		[ChoiceName("Positive Integer 32-bit")]
		PositiveInt32 = 6,

		/// <summary>
		/// Indicates that the value should be treated as a whole number from 1 to 9223372036854775807.
		/// </summary>
		[ChoiceName("Positive Integer 64-bit")]
		PositiveInt64 = 7,

		/// <summary>
		/// Indicates that the value should be treated as a Boolean with only True or False valid values.
		/// </summary>
		[ChoiceName("True/False")]
		TrueFalse = 8,

		/// <summary>
		/// Someone made a different choice in the environment, and we're not able to map it back to an enum.
		/// </summary>
		Unknown
	}
}
