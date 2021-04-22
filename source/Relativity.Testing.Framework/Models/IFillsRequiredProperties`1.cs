namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the interface for entities that can set their required properties with values.
	/// </summary>
	/// <typeparam name="T">The entity type.</typeparam>
	public interface IFillsRequiredProperties<T>
	{
		/// <summary>
		/// Fills the required properties.
		/// </summary>
		/// <returns>The same object instance.</returns>
		T FillRequiredProperties();
	}
}
