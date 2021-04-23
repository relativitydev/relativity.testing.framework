namespace Relativity.Testing.Framework.Models
{
	public class NativeImportOptions : DocumentImportOptionsBase
	{
		/// <summary>
		/// Gets or sets the name of the Field that contains the full path and filename for the native files.
		/// </summary>
		public string NativeFilePathColumnName { get; set; } = "Native File Path";

		/// <summary>
		/// Gets or sets the name of a metadata field used to build the folder structure for the workspace.
		/// </summary>
		public string FolderColumnName { get; set; }

		/// <summary>
		/// Gets or sets field delimiter to use when writing out the bulk load file.
		/// Default value is empty string.
		/// </summary>
		public string BulkLoadFileFieldDelimiter { get; set; } = string.Empty;

		/// <summary>
		/// Gets or sets the value indicates whether native files are used as links or copied to the Relativity
		/// instance designated as the destination.
		/// </summary>
		public NativeFileCopyMode NativeFileCopyMode { get; set; } = NativeFileCopyMode.CopyFiles;
	}
}
