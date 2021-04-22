namespace Relativity.Testing.Framework.Configuration
{
	/// <summary>
	/// Represents the Relativity instance configuration.
	/// </summary>
	public class RelativityInstanceConfiguration
	{
		private string _restServicesHostAddress;

		private string _rsapiServicesHostAddress;

		private string _webApiHostAddress;

		/// <summary>
		/// Gets or sets the type of the server binding.
		/// Is a protocol/schema used to connect with Relativity, e.g. HTTP or HTTPS.
		/// </summary>
		public string ServerBindingType { get; set; }

		/// <summary>
		/// Gets or sets the Relativity host address.
		/// The fully-qualified host (hostname or hostname + port) of the machine hosting Relativity.
		/// </summary>
		public string RelativityHostAddress { get; set; }

		/// <summary>
		/// Gets or sets the Realtivity admin (does not need to be an actual system admin) username
		/// that is used for API communication.
		/// </summary>
		public string AdminUsername { get; set; }

		/// <summary>
		/// Gets or sets the password associated with <see cref="AdminUsername"/>.
		/// </summary>
		public string AdminPassword { get; set; }

		/// <summary>
		/// Gets or sets the REST services host address.
		/// e.g. reg-a.r1.kcura.com
		/// If the value is not set, returns <see cref="RelativityHostAddress"/>.
		/// </summary>
		public string RestServicesHostAddress
		{
			get => _restServicesHostAddress ?? RelativityHostAddress;
			set => _restServicesHostAddress = value;
		}

		/// <summary>
		/// Gets or sets the RSAPI services host address.
		/// e.g. reg-a-services.r1.kcura.com
		/// If the value is not set, returns <see cref="RelativityHostAddress"/>.
		/// </summary>
		public string RsapiServicesHostAddress
		{
			get => _rsapiServicesHostAddress ?? RelativityHostAddress;
			set => _rsapiServicesHostAddress = value;
		}

		/// <summary>
		/// Gets or sets the Web API host address.
		/// e.g. reg-a.r1.kcura.com
		/// If the value is not set, returns <see cref="RelativityHostAddress"/>.
		/// </summary>
		public string WebApiHostAddress
		{
			get => _webApiHostAddress ?? RelativityHostAddress;
			set => _webApiHostAddress = value;
		}

		/// <summary>
		/// Gets or sets the directory to use for RAP installation.
		/// </summary>
		public string RapDirectory { get; set; }

		/// <summary>
		/// Gets or sets the locator for the instance of the SQL server to be used.
		/// e.g. RelativityInstanceName/EDDSINSTANCE001.
		/// </summary>
		public string SqlServer { get; set; }

		/// <summary>
		/// Gets or sets the SQL username.
		/// </summary>
		public string SqlUsername { get; set; }

		/// <summary>
		/// Gets or sets the password associated with <see cref="SqlUsername"/>.
		/// </summary>
		public string SqlPassword { get; set; }

		/// <summary>
		/// Gets or sets the location to save logs and screenshots to./>.
		/// Default is "Results".
		/// </summary>
		public string ResultsLocation { get; set; } = "Results";

		/// <summary>
		/// Merges the default configuration settings into this instance.
		/// Each property of this instance having <see langword="null"/> will be set with the corresponding value of <paramref name="defaultConfiguration"/> object.
		/// </summary>
		/// <param name="defaultConfiguration">The default configuration.</param>
		/// <returns>This instance.</returns>
		public RelativityInstanceConfiguration MergeWithDefault(RelativityInstanceConfiguration defaultConfiguration)
		{
			ServerBindingType = ServerBindingType ?? defaultConfiguration.ServerBindingType;
			RelativityHostAddress = RelativityHostAddress ?? defaultConfiguration.RelativityHostAddress;

			AdminUsername = AdminUsername ?? defaultConfiguration.AdminUsername;
			AdminPassword = AdminPassword ?? defaultConfiguration.AdminPassword;

			RestServicesHostAddress = RestServicesHostAddress ?? defaultConfiguration.RestServicesHostAddress;
			RsapiServicesHostAddress = RsapiServicesHostAddress ?? defaultConfiguration.RsapiServicesHostAddress;
			WebApiHostAddress = WebApiHostAddress ?? defaultConfiguration.WebApiHostAddress;

			RapDirectory = RapDirectory ?? defaultConfiguration.RapDirectory;

			SqlServer = SqlServer ?? defaultConfiguration.SqlServer;
			SqlUsername = SqlUsername ?? defaultConfiguration.SqlUsername;
			SqlPassword = SqlPassword ?? defaultConfiguration.SqlPassword;

			return this;
		}
	}
}
