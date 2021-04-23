using System;

namespace Relativity.Testing.Framework.Strategies
{
	/// <summary>
	/// Represents the service that resolves a strategy depending on the version.
	/// </summary>
	public interface IStrategyResolveService
	{
		/// <summary>
		/// Resolves the most applicable strategy depending on the version.
		/// </summary>
		/// <typeparam name="T">The type of the strategy.</typeparam>
		/// <param name="strategies">The strategies.</param>
		/// <param name="version">The version.</param>
		/// <returns>The most applicable strategy or throws <see cref="StrategyNotFoundException"/>.</returns>
		/// <exception cref="StrategyNotFoundException">No applicable strategy found.</exception>
		T Resolve<T>(T[] strategies, string version);

		/// <summary>
		/// Resolves the most applicable strategy depending on the version.
		/// </summary>
		/// <param name="strategyType">Type of the strategy.</param>
		/// <param name="strategies">The strategies.</param>
		/// <param name="version">The version.</param>
		/// <returns>The most applicable strategy or throws <see cref="StrategyNotFoundException" />.</returns>
		/// <exception cref="StrategyNotFoundException">No applicable strategy found.</exception>
		object Resolve(Type strategyType, object[] strategies, string version);
	}
}
