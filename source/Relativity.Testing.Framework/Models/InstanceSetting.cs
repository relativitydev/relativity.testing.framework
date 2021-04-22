using Relativity.Testing.Framework.Attributes;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents an Instance Setting object.
	/// </summary>
	[ObjectTypeName("InstanceSetting")]
	public class InstanceSetting : NamedArtifact, IFillsRequiredProperties<InstanceSetting>
	{
		/// <summary>
		/// Gets or sets the name of the machine that value of the instance setting applies to.
		/// </summary>
		[FieldName("Machine Name")]
		public string Machine { get; set; }

		/// <summary>
		/// Gets or sets the description of the instance setting.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// Gets or sets the initial value of the instance setting.
		/// </summary>
		public string InitialValue { get; set; }

		/// <summary>
		/// Gets or sets the name of the section in the Instance setting table where the instance setting is being added.
		/// </summary>
		public string Section { get; set; }

		/// <summary>
		/// Gets or sets the value of the instance setting.
		/// </summary>
		public string Value { get; set; }

		/// <summary>
		/// Gets or sets the type of the value for the instance setting.
		/// </summary>
		public InstanceSettingValueType? ValueType { get; set; }

		/// <summary>
		/// Fills the required properties.
		/// </summary>
		/// <returns>The same <see cref="InstanceSetting"/> object instance.</returns>
		public InstanceSetting FillRequiredProperties()
		{
			if (string.IsNullOrWhiteSpace(Name))
			{
				Name = Randomizer.GetString("AT_Name_");
			}

			if (string.IsNullOrWhiteSpace(Section))
			{
				Section = Randomizer.GetString("AT_Section_");
			}

			if (string.IsNullOrWhiteSpace(Description))
			{
				Description = string.Empty;
			}

			if (string.IsNullOrWhiteSpace(Value))
			{
				Value = string.Empty;
			}

			if (ValueType == null || ValueType == InstanceSettingValueType.Default)
			{
				ValueType = InstanceSettingValueType.Text;
			}

			if (string.IsNullOrWhiteSpace(InitialValue))
			{
				InitialValue = string.Empty;
			}

			if (string.IsNullOrWhiteSpace(Machine))
			{
				Machine = string.Empty;
			}

			return this;
		}
	}
}
