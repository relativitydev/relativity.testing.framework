namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the possible Field Types.
	/// </summary>
	public enum FieldType
	{
		Empty = -1,
		FixedLength = 0,
		FixedLengthText = 0,
		WholeNumber = 1,
		Date = 2,
		YesNo = 3,
		LongText = 4,
		SingleChoice = 5,
		Decimal = 6,
		Currency = 7,
		MultipleChoice = 8,
		File = 9,
		SingleObject = 10,
		User = 11,
		MultipleObject = 13,
		Unknown
	}
}
