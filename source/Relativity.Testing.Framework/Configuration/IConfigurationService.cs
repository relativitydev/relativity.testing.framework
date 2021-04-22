using Microsoft.Extensions.Configuration;

namespace Relativity.Testing.Framework.Configuration
{
	/// <summary>
	/// Represents the configuration service that provides a set of members for getting the configuration parameters.
	/// </summary>
	public interface IConfigurationService
	{
		/// <summary>
		/// Gets the Relativity instance configuration.
		/// </summary>
		RelativityInstanceConfiguration RelativityInstance { get; }

		/// <summary>
		/// Gets the configuration root.
		/// </summary>
		IConfigurationRoot ConfigurationRoot { get; }

		/// <summary>
		/// Bind the configuration to a new instance of type <typeparamref name="T"/>.
		/// </summary>
		/// <typeparam name="T">The type of the new instance to bind.</typeparam>
		/// <returns>The new instance of <typeparamref name="T"/> if successful, <c>default(T)</c> otherwise.</returns>
		T Get<T>();

		/// <summary>
		/// Gets the configuration value/section by the specified <paramref name="key"/> and converts it to a new instance of type <typeparamref name="T"/>.
		/// Throws <see cref="ConfigurationKeyNotFoundException"/> if the configuration by the specified <paramref name="key"/> is not found.
		/// </summary>
		/// <typeparam name="T">The type to convert the value to.</typeparam>
		/// <param name="key">The key of the configuration value/section.</param>
		/// <returns>The new instance of <typeparamref name="T"/>.</returns>
		T GetValue<T>(string key);

		/// <summary>
		/// Gets the string configuration value by the specified <paramref name="key"/>.
		/// Throws <see cref="ConfigurationKeyNotFoundException"/> if the configuration by the specified <paramref name="key"/> is not found.
		/// </summary>
		/// <param name="key">The key of the configuration value.</param>
		/// <returns>The configuration value.</returns>
		string GetValue(string key);

		/// <summary>
		/// Gets the configuration value/section by the specified <paramref name="key" /> and converts it to a new instance of type <typeparamref name="T" />;
		/// or <c>default(T)</c> if not found.
		/// </summary>
		/// <typeparam name="T">The type to convert the value to.</typeparam>
		/// <param name="key">The key of the configuration value/section.</param>
		/// <returns>The new instance of <typeparamref name="T" /> if successful, <c>default(T)</c> otherwise.</returns>
		T GetValueOrDefault<T>(string key);

		/// <summary>
		/// Gets the configuration value/section by the specified <paramref name="key" /> and converts it to a new instance of type <typeparamref name="T" />;
		/// or <paramref name="defaultValue"/> if not found.
		/// </summary>
		/// <typeparam name="T">The type to convert the value to.</typeparam>
		/// <param name="key">The key of the configuration value/section.</param>
		/// <param name="defaultValue">The default value to use if no value is found.</param>
		/// <returns>The new instance of <typeparamref name="T" /> if successful, <paramref name="defaultValue"/> otherwise.</returns>
		T GetValueOrDefault<T>(string key, T defaultValue);

		/// <summary>
		/// Gets the configuration value by the specified <paramref name="key"/> or <see langword="null"/> if not found.
		/// </summary>
		/// <param name="key">The key of the configuration value.</param>
		/// <returns>The configuration value or <see langword="null"/>.</returns>
		string GetValueOrDefault(string key);

		/// <summary>
		/// Gets the configuration value by the specified key or <paramref name="defaultValue" /> if not found.
		/// </summary>
		/// <param name="key">The key of the configuration value.</param>
		/// <param name="defaultValue">The default value to use if no value is found.</param>
		/// <returns>The configuration value or <paramref name="defaultValue" />.</returns>
		string GetValueOrDefault(string key, string defaultValue);
	}
}
