namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the settings for displaying speaker notes and page orientation for presentation slides, such as Microsoft PowerPoint.
	/// </summary>
	public class ImagingPresentationOptions
	{
		/// <summary>
		/// Gets or sets a value indicating whether speaker’s notes display at the bottom of presentation slides.
		/// </summary>
		/// <remarks>Corresponds to the "Show speaker notes" option under Presentation Options.</remarks>
		public bool ShowSpeakerNotes { get; set; }

		/// <summary>
		/// Gets or sets orientation of presentation slides, such as landscape, portrait, or original setting.
		/// </summary>
		/// <remarks>Corresponds to Slide Orientation option under the Presentation Options tab.</remarks>
		public ImagingElementOrientation SlideOrientation { get; set; }
	}
}
