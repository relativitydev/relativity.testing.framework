namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// The available return types of a script action.
	/// </summary>
	public enum ActionReturnType
	{
		/// <summary>
		/// The action will return the number of rows affected by the query.
		/// </summary>
		Status = 0,

		/// <summary>
		/// The action will return the output of the query in tabular form.
		/// </summary>
		Table = 1,

		/// <summary>
		/// Someone made a different choice in the environment, and we're not able to map it back to an enum.
		/// </summary>
		Unknown
	}
}
