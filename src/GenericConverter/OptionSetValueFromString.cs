using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;

namespace GenericConverter;

// ReSharper disable once UnusedType.Global
public class OptionSetValueFromString : ConvertFromString
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="T:System.Object" /> class.
    /// </summary>
    /// <exception cref="ArgumentNullException"><paramref name="convertFromString" /> is <see langword="null" />.</exception>
    public OptionSetValueFromString(IConvertFromString convertFromString)
        : base(convertFromString)
    {
        ArgumentNullException.ThrowIfNull(convertFromString);
    }

    public override bool AmIResponsible => OutputType is { Name: "OptionSetValue" } || OutputAttributeTypeCode.Equals(AttributeTypeCode.Picklist);

    protected override object InnerOutput(string input) => input == null ? null : new OptionSetValue(Convert.ToInt32(input));
}