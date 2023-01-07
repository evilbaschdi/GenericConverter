using Microsoft.Xrm.Sdk.Metadata;

namespace GenericConverter;

// ReSharper disable once UnusedType.Global
public class DoubleFromString : ConvertFromString
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="T:System.Object" /> class.
    /// </summary>
    /// <exception cref="ArgumentNullException"><paramref name="convertFromString" /> is <see langword="null" />.</exception>
    public DoubleFromString(IConvertFromString convertFromString)
        : base(convertFromString)
    {
        if (convertFromString == null)
        {
            throw new ArgumentNullException(nameof(convertFromString));
        }
    }

    public override bool AmIResponsible => OutputType is { Name: "Double" } || OutputAttributeTypeCode.Equals(AttributeTypeCode.Double);

    protected override object InnerOutput(string input)
    {
        return input == null ? null : Convert.ToDouble(input);
    }
}