using System.Collections.Generic;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the word processing options set on an <see cref="ImagingProfile"/> instance.
	/// </summary>
	public class ImagingWordOptions
	{
		/// <summary>
		/// Gets or sets a value indicating whether to display any markup added to the document through the Track Changes feature in Microsoft Word.
		/// </summary>
		/// <remarks>Corresponds to the Show track changes Option under the  Word Processing Options tab.</remarks>
		public bool ShowTrackChanges { get; set; }

		/// <summary>
		/// Gets or sets the word processing option for page orientation, such portrait, landscape, or original orientation.
		/// </summary>
		/// <remarks>Corresponds to the Page Orientation options under the Word Processing Options tab.</remarks>
		public ImagingElementOrientation PageOrientation { get; set; }

		/// <summary>
		/// Gets or sets the word processing options for rendering comments, field codes, and hidden text.
		/// </summary>
		/// <remarks>References the Show: option on the Word Processing Options tab in the Image Profile editor.</remarks>
		public HashSet<ImagingWordInclude> Include { get; set; }
	}
}
