namespace Relativity.Testing.Framework.Models
{
    /// <summary>
    /// Represents the different field display types.
    /// </summary>
    public enum FieldDisplayType
    {
        Text = 0,
        MultilineText = 1,
#pragma warning disable CA1720 // Identifier contains type name
        Decimal = 2,
        Integer = 3,
#pragma warning restore CA1720 // Identifier contains type name
        CodeDropDown = 4,
        CodeRadioButtonList = 5,
        Date = 6,
        BooleanDropDown = 7,
        Currency = 8,
        CheckBox = 9,
        CodeCheckBoxList = 10,
        RichText = 11,
        File = 12,
        ObjectPicker = 16,
        UserDropdown = 19,
        UserPicker = 20,
        MultiCodePicker = 21,
        ObjectsPicker = 22,
        SingleCodePicker = 23,
        BooleanRadioButton = 24,
        ObjectDropDown = 25,
        InlineRichText = 26,
        Unknown
    }
}
