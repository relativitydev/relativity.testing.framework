using Relativity.Testing.Framework.Attributes;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// The enumeration of <see cref="User"/> document viewer options.
	/// </summary>
	[ChoiceType(1000023)]
	public enum UserDocumentViewer
	{
		/// <summary>
		/// The default value.
		/// </summary>
		Default,

		/// <summary>
		/// The HTML value.
		/// </summary>
		[ChoiceName("HTML")]
		Html,

		/// <summary>
		/// The ActiveX value.
		/// </summary>
		[ChoiceName("ActiveX")]
		ActiveX,

		/// <summary>
		/// Use the Relativity Review Interface to review documents.
		/// </summary>
		RelativityReview = 3,

		/// <summary>
		/// Someone made a different choice in the environment, and we're not able to map it back to an enum.
		/// </summary>
		Unknown
	}
}
