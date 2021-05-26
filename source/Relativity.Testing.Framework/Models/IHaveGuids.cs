using System;
using System.Collections.Generic;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the interface for model classes that have guid list.
	/// </summary>
	public interface IHaveGuids
	{
		/// <summary>
		/// Gets or sets guids list.
		/// </summary>
		List<Guid> Guids { get; set; }
	}
}
