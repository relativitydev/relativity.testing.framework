using System.Diagnostics;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the Relativity artifact object that has name property.
	/// Can be used as a base class for most Relativity object classes.
	/// </summary>
	[DebuggerDisplay("{Name}")]
	public class NamedArtifact : Artifact, IHasName
	{
		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		public string Name { get; set; }
	}
}
