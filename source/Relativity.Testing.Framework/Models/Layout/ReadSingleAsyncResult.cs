using System;
using System.Collections.Generic;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Object representing a response from the LayoutBuilderManager's ReadSingleAsync endpoint.
	/// </summary>
	public class ReadSingleAsyncResult
	{
		/// <summary>
		/// Gets or sets a value indicating whether AllowCopyFromPrevious is set.
		/// </summary>
		public bool AllowCopyFromPrevious { get; set; }

		/// <summary>
		/// Gets or sets the artifact type id.
		/// </summary>
		public int ArtifactTypeID { get; set; }

		/// <summary>
		/// Gets or sets the Categories on the layout.
		/// </summary>
		public List<Category> Groups { get; set; }

		/// <summary>
		/// Gets or sets the associated guids.
		/// </summary>
		public List<Guid> Guids { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether IsLocked is set.
		/// </summary>
		public bool IsLocked { get; set; }

		/// <summary>
		/// Gets or sets the artifact id of the layout.
		/// </summary>
		public int LayoutID { get; set; }

		/// <summary>
		/// Gets or sets the name of the layout.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether OverwriteProtection is set.
		/// </summary>
		public string OverwriteProtection { get; set; }
	}
}
