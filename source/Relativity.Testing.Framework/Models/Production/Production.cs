using System;
using System.Collections.Generic;
using System.Diagnostics;
using Castle.Core.Internal;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents a production model.
	/// </summary>
	[DebuggerDisplay("{ArtifactID} {Name}")]
	public class Production : NamedArtifact
	{
		/// <summary>
		/// Gets or sets one or more data sources that hold the documents to be included in the production.
		/// </summary>
		public List<ProductionDataSource> DataSources { get; set; }

		/// <summary>
		///  Gets or sets the numbering scheme for the production documents.
		/// </summary>
		public ProductionNumbering Numbering { get; set; }

		/// <summary>
		/// Gets or sets what kind of information goes on the page headers.
		/// </summary>
		public ProductionHeaders Headers { get; set; }

		/// <summary>
		/// Gets or sets what kind of information goes on the page footers.
		/// </summary>
		public ProductionFooters Footers { get; set; }

		/// <summary>
		/// Gets or sets what kind of details goes on the production.
		/// </summary>
		public ProductionDetails Details { get; set; }

		/// <summary>
		/// Gets or sets Production metadata. The information in this object is created and updated by Relativity.
		/// </summary>
		public ProductionMetadata ProductionMetadata { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether production should be copied when the containing workspace is used as a template for creating another workspace.
		/// </summary>
		public bool ShouldCopyInstanceOnWorkspaceCreate { get; set; }

		/// <summary>
		/// Gets or sets the first Bates number value of the production after it is completed.
		/// </summary>
		public string FirstBatesValue { get; set; }

		/// <summary>
		/// Gets or sets the last Bates number value of the production after it is completed.
		/// </summary>
		public string LastBatesValue { get; set; }

		/// <summary>
		/// Gets or sets relativityApplications associated with this Production Set.
		/// </summary>
		public List<NamedArtifact> RelativityApplications { get; set; }

		/// <summary>
		/// Gets or sets optional field for recording additional information associated with the production as keywords.
		/// </summary>
		public string Keywords { get; set; } = string.Empty;

		/// <summary>
		/// Gets or sets detailed description of the production.
		/// </summary>
		public string Notes { get; set; } = string.Empty;

		/// <summary>
		/// Fills the required properties.
		/// </summary>
		/// <returns>The same <see cref="Production"/> object instance.</returns>
		public Production FillRequiredProperties()
		{
			if (string.IsNullOrWhiteSpace(Name))
			{
				Name = Randomizer.GetString("AT_");
			}

			if (DataSources.IsNullOrEmpty())
			{
				DataSources = new List<ProductionDataSource>();
			}

			if (Numbering == null)
			{
				Numbering = new ProductionNumbering
				{
					NumberingType = NumberingType.OriginalImage,
					AttachmentRelationalField = new NamedArtifact()
				};
			}

			if (Details == null)
			{
				Details = new ProductionDetails
				{
					BrandingFont = "Arial",
					BrandingFontSize = 10,
					DateProduced = DateTime.MinValue,
					EmailRecipients = string.Empty,
					PlaceholderImageFormat = PlaceholderImageFormat.Tiff,
					ScaleBrandingFont = false,
					WrapBrandingText = false
				};
			}

			Headers = new ProductionHeaders
			{
				LeftHeader = new ProductionHeaderFooter
				{
					Type = HeaderFooterType.None,
					Field = new NamedArtifact { Name = string.Empty },
					FreeText = string.Empty,
					FriendlyName = "Left Header",
					AdvancedFormatting = string.Empty
				},
				CenterHeader = new ProductionHeaderFooter
				{
					Type = HeaderFooterType.None,
					Field = new NamedArtifact { Name = string.Empty },
					FreeText = string.Empty,
					FriendlyName = "Center Header",
					AdvancedFormatting = string.Empty
				},
				RightHeader = new ProductionHeaderFooter
				{
					Type = HeaderFooterType.None,
					Field = new NamedArtifact { Name = string.Empty },
					FreeText = string.Empty,
					FriendlyName = "Right Header",
					AdvancedFormatting = string.Empty
				}
			};

			Footers = new ProductionFooters
			{
				LeftFooter = new ProductionHeaderFooter
				{
					Type = HeaderFooterType.None,
					Field = new NamedArtifact { Name = string.Empty },
					FreeText = string.Empty,
					FriendlyName = "Left Footer",
					AdvancedFormatting = string.Empty
				},
				CenterFooter = new ProductionHeaderFooter
				{
					Type = HeaderFooterType.None,
					Field = new NamedArtifact { Name = string.Empty },
					FreeText = string.Empty,
					FriendlyName = "Center Footer",
					AdvancedFormatting = string.Empty
				},
				RightFooter = new ProductionHeaderFooter
				{
					Type = HeaderFooterType.None,
					Field = new NamedArtifact { Name = string.Empty },
					FreeText = string.Empty,
					FriendlyName = "Right Footer",
					AdvancedFormatting = string.Empty
				}
			};

			if (RelativityApplications == null)
			{
				RelativityApplications = new List<NamedArtifact>();
			}

			return this;
		}
	}
}
