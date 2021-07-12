namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents document types in the Imaging API.
	/// </summary>
	public class NativeType : NamedArtifact
	{
		/// <summary>
		/// Gets or sets the basic imaging category for this native type.
		/// </summary>
		public BasicCategory BasicCategory { get; set; }

		/// <summary>
		/// Gets or sets the native imaging category for this native type.
		/// </summary>
		public NativeCategory? NativeCategory { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether to use native imaging on this native type.
		/// </summary>
		public bool UseNativeImaging { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this native type is restricted from imaging by default.
		/// </summary>
		public bool RestrictedFromImagingByDefault { get; set; }

		/// <summary>
		/// Gets or sets the identifier of the file type used by Invariant.
		/// </summary>
		public int FileTypeID { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether native type is restricted from being downloaded.
		/// </summary>
		public bool PreventNativeDownload { get; set; }
	}
}
