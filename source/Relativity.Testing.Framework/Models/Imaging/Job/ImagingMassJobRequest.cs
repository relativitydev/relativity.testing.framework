namespace Relativity.Testing.Framework.Models
{
	public class ImagingMassJobRequest
	{
		/// <summary>
		/// Gets or sets the id of the imaging profile to use.
		/// </summary>
		public int ProfileID { get; set; }

		/// <summary>
		/// Gets or sets the process id of the mass imaging operation.
		/// </summary>
		public string MassProcessID { get; set; }

		/// <summary>
		/// Gets or sets the type of Document source to be used for generating Images in this mass operation.
		/// It defaults to using Document Natives.
		/// </summary>
		public ImagingSourceType SourceType { get; set; } = ImagingSourceType.Native;
	}
}
