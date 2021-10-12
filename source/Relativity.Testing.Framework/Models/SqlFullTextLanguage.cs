using System.ComponentModel;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Defines the possible SQLFullTextLanguage for a workspace.
	/// </summary>
	public enum SqlFullTextLanguage
	{
		Neutral = 0,
		Arabic = 1025,

		[Description("Bengali (India)")]
		Bengali = 1093,

		Bulgarian = 1026,
		Brazilian = 1046,

		[Description("British English")]
		BritishEnglish = 2057,

		Catalan = 1027,

		[Description("Chinese (Hong Kong SAR, PRC)")]
		Chinese = 3076,

		[Description("Chinese (Macao SAR)")]
		ChineseMacao = 5124,

		[Description("Chinese (Singapore)")]
		ChineseSingapore = 4100,

		Croatian = 1050,
		Czech = 1029,
		Danish = 1030,
		Dutch = 1043,
		English = 1033,
		French = 1036,
		German = 1031,
		Greek = 1032,
		Gujarati = 1095,
		Hebrew = 1037,
		Hindi = 1081,
		Icelandic = 1039,
		Indonesian = 1057,
		Italian = 1040,
		Japanese = 1041,
		Kannada = 1099,
		Korean = 1042,
		Latvian = 1062,
		Lithuanian = 1063,

		[Description("Malay - Malaysia")]
		Malay = 1086,

		Malayalam = 1100,
		Marathi = 1102,

		[Description("Bokmål")]
		Norwegian = 1044,

		Polish = 1045,
		Portuguese = 2070,
		Punjabi = 1094,
		Romanian = 1048,
		Russian = 1049,

		[Description("Serbian (Cyrillic)")]
		SerbianCyrillic = 3098,

		[Description("Serbian (Latin)")]
		SerbianLatin = 2074,

		[Description("Simplified Chinese")]
		SimplifiedChinese = 2052,

		Slovak = 1051,
		Slovenian = 1060,
		Spanish = 3082,
		Swedish = 1053,
		Tamil = 1097,
		Telugu = 1098,
		Thai = 1054,

		[Description("Traditional Chinese")]
		TraditionalChinese = 1028,

		Turkish = 1055,
		Ukranian = 1058,
		Urdu = 1056,
		Vietnamese = 1066
	}
}
