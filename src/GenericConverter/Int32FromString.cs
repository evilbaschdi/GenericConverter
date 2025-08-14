using Microsoft.Xrm.Sdk.Metadata;

namespace GenericConverter;

// ReSharper disable once UnusedType.Global
public class Int32FromString : ConvertFromString
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="T:System.Object" /> class.
    /// </summary>
    /// <exception cref="ArgumentNullException"><paramref name="convertFromString" /> is <see langword="null" />.</exception>
    public Int32FromString(IConvertFromString convertFromString)
        : base(convertFromString)
    {
        ArgumentNullException.ThrowIfNull(convertFromString);
    }

    public override bool AmIResponsible => OutputType is { Name: "Int32" } || OutputAttributeTypeCode.Equals(AttributeTypeCode.Integer);

    protected override object InnerOutput(string input) => input == null ? null : Convert.ToInt32(input);
}