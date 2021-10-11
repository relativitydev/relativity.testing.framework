using Relativity.Testing.Framework.Attributes;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// The possible TabIconIdentifiers.
	/// </summary>
	public enum TabIconIdentifier
	{
		None = 0,
		[ChoiceName("sidebar-default-tab")]
		Tab = 1,
		[ChoiceName("sidebar-access")]
		Access = 2,
		[ChoiceName("sidebar-analytics")]
		Analytics = 3,
		[ChoiceName("sidebar-bar-chart")]
		BarChart = 4,
		[ChoiceName("sidebar-case")]
		Case = 5,
		[ChoiceName("sidebar-case-dynamics")]
		CaseDynamics = 6,
		[ChoiceName("sidebar-configure")]
		Configure = 7,
		[ChoiceName("sidebar-data-transfer")]
		DataTransfer = 8,
		[ChoiceName("sidebar-documents")]
		Documents = 9,
		[ChoiceName("sidebar-download")]
		Download = 10,
		[ChoiceName("sidebar-export")]
		Export = 11,
		[ChoiceName("sidebar-folder")]
		Folder = 12,
		[ChoiceName("sidebar-infrastructure")]
		Infrastructure = 13,
		[ChoiceName("sidebar-monitor")]
		Monitor = 14,
		[ChoiceName("sidebar-page")]
		Page = 15,
		[ChoiceName("sidebar-pie-chart")]
		PieChart = 16,
		[ChoiceName("sidebar-processing")]
		Processing = 17,
		[ChoiceName("sidebar-production")]
		Production = 18,
		[ChoiceName("sidebar-resources")]
		Resources = 19,
		[ChoiceName("sidebar-review")]
		Review = 20,
		[ChoiceName("sidebar-upload")]
		Upload = 21,
		[ChoiceName("sidebar-workspaces")]
		Workspaces = 22,
		Unknown
	}
}
