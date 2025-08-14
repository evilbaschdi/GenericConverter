using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;

namespace GenericConverter;

// ReSharper disable once UnusedType.Global
public class MoneyFromString : ConvertFromString
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="T:System.Object" /> class.
    /// </summary>
    /// <exception cref="ArgumentNullException"><paramref name="convertFromString" /> is <see langword="null" />.</exception>
    public MoneyFromString(IConvertFromString convertFromString)
        : base(convertFromString)
    {
        ArgumentNullException.ThrowIfNull(convertFromString);
    }

    public override bool AmIResponsible => OutputType is { Name: "Money" } || OutputAttributeTypeCode.Equals(AttributeTypeCode.Money);

    protected override object InnerOutput(string input) => input == null ? null : new Money(Convert.ToDecimal(input));
}