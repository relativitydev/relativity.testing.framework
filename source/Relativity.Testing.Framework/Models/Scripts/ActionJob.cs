using System.Collections.Generic;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents a script action job.
	/// </summary>
	public class ActionJob
	{
		/// <summary>
		/// Gets or sets the name of the action.
		/// </summary>
		/// <remarks>
		/// This value is optional and is declared in the script definition.
		/// </remarks>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the return type of the action.
		/// </summary>
		public ActionReturnType ReturnType { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether html tags should be rendered by the browser.
		/// </summary>
		/// <remarks>
		/// If set to "true", allows HTML tags to be interpreted by the browser instead of rendered as markup.
		/// </remarks>
		public bool AllowHtmlTagsInOutput { get; set; }

		/// <summary>
		/// Gets or sets the error message when an error.
		/// </summary>
		public string ErrorMessage { get; set; }

		/// <summary>
		/// Gets or sets the column information when the <see cref="ReturnType"/> is <see cref="ActionReturnType.Table"/>.
		/// </summary>
		/// <remarks>
		/// This property will only be set when the <see cref="ReturnType"/> is <see cref="ActionReturnType.Table"/>.
		/// This property will only be set when the action has completed successfully.
		/// </remarks>
		public List<ActionColumn> Columns { get; set; }

		/// <summary>
		/// Gets or sets the number of rows affected by the completed action when the <see cref="ReturnType"/> is <see cref="ActionReturnType.Status"/>.
		/// </summary>
		/// <remarks>
		/// This property will only be set when the <see cref="ReturnType"/> is <see cref="ActionReturnType.Status"/>.
		/// This property will only be set when the action has completed sucessfully.
		/// </remarks>
		public int? RowsAffected { get; set; }

		/// <summary>
		/// Gets or sets the current status of the job.
		/// </summary>
		public RunJobStatus Status { get; set; }

		/// <summary>
		/// Gets or sets a list of RESTful operations that a user has permissions to perform on the script action job.
		/// </summary>
		public List<Action> Actions { get; set; }

		/// <summary>
		/// Gets or sets a list of unsupported and read-only properties on the script action job.
		/// </summary>
		public Meta Meta { get; set; }
	}
}
