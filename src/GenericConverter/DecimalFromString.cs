using Microsoft.Xrm.Sdk.Metadata;

namespace GenericConverter;

// ReSharper disable once UnusedType.Global
public class DecimalFromString : ConvertFromString
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="T:System.Object" /> class.
    /// </summary>
    /// <exception cref="ArgumentNullException"><paramref name="convertFromString" /> is <see langword="null" />.</exception>
    public DecimalFromString(IConvertFromString convertFromString)
        : base(convertFromString)
    {
        ArgumentNullException.ThrowIfNull(convertFromString);
    }

    public override bool AmIResponsible => OutputType is { Name: "Decimal" } || OutputAttributeTypeCode.Equals(AttributeTypeCode.Decimal);

    protected override object InnerOutput(string input) => input == null ? null : Convert.ToDecimal(input);
}