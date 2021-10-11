using System.Collections.Generic;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// A collection of information about fields on a given static object that may have restrictions.
	/// </summary>
	public class Meta
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Meta"/> class.
		/// </summary>
		public Meta()
		{
			Unsupported = new List<string>();
			ReadOnly = new List<string>();
		}

		/// <summary>
		/// Gets or sets a list of fields on the static object that are not supported on the given object instance.
		/// </summary>
		/// <remarks>
		/// For example, only workspace Tabs can be linked to a Relativity Application. The Meta information for an admin Tab will list its RelativityApplications field as Unsupported.
		/// </remarks>
		public List<string> Unsupported { get; set; }

		/// <summary>
		/// Gets or sets a list of fields on the given static object that can't be updated.
		/// </summary>
		public List<string> ReadOnly { get; set; }
	}
}
