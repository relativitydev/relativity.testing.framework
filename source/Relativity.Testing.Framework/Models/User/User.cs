using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Relativity.Testing.Framework.Attributes;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the Relativity user object.
	/// </summary>
	[DebuggerDisplay("{LastName,nq}, {FirstName,nq}")]
	public class User : NamedArtifact, IFillsRequiredProperties<User>
	{
		private const int EveryoneGroupID = 1015005;

		/// <summary>
		/// The default item list page length.
		/// </summary>
		public const int DefaultItemListPageLength = 200;

		/// <summary>
		/// The default maximum password age.
		/// </summary>
		public const int DefaultMaximumPasswordAge = 365;

		/// <summary>
		/// Gets or sets the first name.
		/// </summary>
		public string FirstName { get; set; }

		/// <summary>
		/// Gets or sets the last name.
		/// </summary>
		public string LastName { get; set; }

		/// <summary>
		/// Gets or sets the full name.
		/// </summary>
		public string FullName { get; set; }

		/// <summary>
		/// Gets or sets the email address.
		/// </summary>
		public virtual string EmailAddress { get; set; }

		/// <summary>
		/// Gets or sets the type of the user.
		/// The default value is "Internal".
		/// </summary>
		public virtual string Type { get; set; } = "Internal";

		/// <summary>
		/// Gets or sets the item list page length.
		/// The default value is <see cref="DefaultItemListPageLength"/>.
		/// </summary>
		public int ItemListPageLength { get; set; } = DefaultItemListPageLength;

		/// <summary>
		/// Gets or sets the client.
		/// </summary>
		public Client Client { get; set; }

		/// <summary>
		/// Gets or sets the default selected file type.
		/// The default value is <see cref="UserDefaultSelectedFileType.Viewer"/>.
		/// </summary>
		public UserDefaultSelectedFileType DefaultSelectedFileType { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the user is beta one.
		/// The default value is <see langword="false"/>.
		/// </summary>
		public bool BetaUser { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the change of settings is allowed.
		/// The default value is <see langword="true"/>.
		/// </summary>
		public bool ChangeSettings { get; set; } = true;

		/// <summary>
		/// Gets or sets the trusted IPs.
		/// </summary>
		[FieldName("Trusted IPs")]
		public string TrustedIPs { get; set; } = string.Empty;

		/// <summary>
		/// Gets or sets a value indicating whether the user has Relativity access.
		/// The default value is <see langword="true"/>.
		/// </summary>
		public bool RelativityAccess { get; set; } = true;

		/// <summary>
		/// Gets or sets a value indicating whether the advanced search is public by default.
		/// The default value is <see langword="true"/>.
		/// </summary>
		public bool AdvancedSearchPublicByDefault { get; set; } = true;

		/// <summary>
		/// Gets or sets a value indicating whether the native viewer cache is ahead.
		/// The default value is <see langword="true"/>.
		/// </summary>
		public bool NativeViewerCacheAhead { get; set; } = true;

		/// <summary>
		/// Gets or sets a value indicating whether the password can be changed.
		/// The default value is <see langword="true"/>.
		/// </summary>
		public bool ChangePassword { get; set; } = true;

		/// <summary>
		/// Gets or sets the maximum password age in days.
		/// The default value is <see cref="DefaultMaximumPasswordAge"/>.
		/// </summary>
		public int MaximumPasswordAge { get; set; } = DefaultMaximumPasswordAge;

		/// <summary>
		/// Gets or sets a value indicating whether to change password on next login.
		/// The default value is <see langword="false"/>.
		/// </summary>
		public bool ChangePasswordNextLogin { get; set; }

		/// <summary>
		/// Gets or sets the password.
		/// </summary>
		public string Password { get; set; }

		/// <summary>
		/// Gets or sets the document skip.
		/// The default value is <see cref="UserDocumentSkip.Enabled"/>.
		/// </summary>
		public UserDocumentSkip DocumentSkip { get; set; }

		/// <summary>
		/// Gets or sets the data focus.
		/// The default value is <c>1</c>.
		/// </summary>
		public int DataFocus { get; set; } = 1;

		/// <summary>
		/// Gets or sets a value indicating whether to enable keyboard shortcuts.
		/// The default value is <see langword="true"/>.
		/// </summary>
		public bool KeyboardShortcuts { get; set; } = true;

		/// <summary>
		/// Gets or sets a value indicating whether to enforce viewer compatibility.
		/// The default value is <see langword="true"/>.
		/// </summary>
		public bool EnforceViewerCompatibility { get; set; } = true;

		/// <summary>
		/// Gets or sets the skip default preference.
		/// The default value is <see cref="UserSkipDefaultPreference.Normal"/>.
		/// </summary>
		public UserSkipDefaultPreference SkipDefaultPreference { get; set; }

		/// <summary>
		/// Gets or sets the document viewer.
		/// The default value is <see cref="UserDocumentViewer.Default"/>.
		/// </summary>
		public UserDocumentViewer DocumentViewer { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this user can change document viewer.
		/// The default value is <see langword="false"/>.
		/// </summary>
		public bool CanChangeDocumentViewer { get; set; }

		/// <summary>
		/// Gets a value indicating whether to show filters.
		/// The default value is <see langword="true"/>.
		/// </summary>
		public bool ShowFilters { get; internal set; } = true;

		/// <summary>
		/// Gets or sets the date on which the used should become disabled.
		/// </summary>
		public DateTime? DisableOnDate { get; set; }

		public List<Artifact> Groups { get; set; }

		/// <summary>
		/// Gets or sets email preferences for user.
		/// </summary>
		[NonField]
		public UserEmailPreference EmailPreference { get; set; }

		/// <summary>
		/// Fills the required properties.
		/// </summary>
		/// <returns>The same <see cref="User"/> object instance.</returns>
		public User FillRequiredProperties()
		{
			if (string.IsNullOrWhiteSpace(FirstName))
				FirstName = Randomizer.GetString();

			if (string.IsNullOrWhiteSpace(LastName))
				LastName = Randomizer.GetString("AT_");

			if (string.IsNullOrWhiteSpace(EmailAddress))
				EmailAddress = Randomizer.GetEmailAddress();

			if (string.IsNullOrWhiteSpace(Password))
				Password = Randomizer.GetPassword();

			if (DefaultSelectedFileType == UserDefaultSelectedFileType.Default)
				DefaultSelectedFileType = UserDefaultSelectedFileType.Viewer;

			if (Groups == null || !Groups.Any())
				Groups = new List<Artifact> { new Artifact { ArtifactID = EveryoneGroupID } };

			return this;
		}
	}
}
