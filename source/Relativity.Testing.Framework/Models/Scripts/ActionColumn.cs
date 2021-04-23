namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents a column returned as part of the results of a script action.
	/// </summary>
	public class ActionColumn
	{
		/// <summary>
		/// Gets or sets the column name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the data type of the column.
		/// </summary>
		public ActionColumnDataType DataType { get; set; }
	}
}
