using System;
using Microsoft.Xrm.Sdk.Metadata;

namespace GenericConverter
{
    // ReSharper disable once UnusedType.Global
    public class BoolFromString : ConvertFromString
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="T:System.Object" /> class.
        /// </summary>
        /// <exception cref="ArgumentNullException"><paramref name="convertFromString" /> is <see langword="null" />.</exception>
        public BoolFromString(IConvertFromString convertFromString)
            : base(convertFromString)
        {
            if (convertFromString == null)
            {
                throw new ArgumentNullException(nameof(convertFromString));
            }
        }

        public override bool AmIResponsible => OutputType != null && OutputType.Name == "Boolean" || OutputAttributeTypeCode.Equals(AttributeTypeCode.Boolean);

        protected override object InnerOutput(string input)
        {
            if (input == null)
            {
                return null;
            }

            return input.ToUpper() switch
            {
                "0" =>
                    false,
                "F" =>
                    false,
                "FALSE" =>
                    false,
                "NO" =>
                    false,
                "1" =>
                    true,
                "T" =>
                    true,
                "TRUE" =>
                    true,
                "YES" =>
                    true,
                _ => false
            };
        }
    }
}