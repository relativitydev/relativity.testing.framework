using System;

namespace Relativity.Testing.Framework.Models
{
	public class TimeStampedNamedArtifact : NamedArtifact
	{
		public NamedArtifact CreatedBy { get; set; }

		public DateTime CreatedOn { get; set; }

		public NamedArtifact LastModifiedBy { get; set; }

		public DateTime LastModifiedOn { get; set; }
	}
}
