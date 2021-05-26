using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the Relativity artifact object that has name and guids properties.
	/// Can be used as a base class for most Relativity object classes.
	/// </summary>
	[DebuggerDisplay("{Name}")]
	public class NamedArtifactWithGuids : NamedArtifact, IHaveGuids
	{
		/// <inheritdoc/>
		public List<Guid> Guids { get; set; }
	}
}
