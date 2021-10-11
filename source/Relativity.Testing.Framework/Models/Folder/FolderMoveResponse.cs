namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the HTTP response that we get back when making a request to the MoveFolderAsync API endpoint.
	/// </summary>
	public class FolderMoveResponse
	{
		/// <summary>
		/// Gets the state of the mass process.
		/// </summary>
		public string ProcessState { get;  internal set; }

		/// <summary>
		/// Gets the number of operations needed to be executed to move the object.
		/// </summary>
		public int TotalOperations { get; internal set; }

		/// <summary>
		/// Gets the number of operations that have been executed.
		/// </summary>
		public int OperationsCompleted { get; internal set; }
	}
}
