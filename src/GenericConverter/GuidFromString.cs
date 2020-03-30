using System;
using Microsoft.Xrm.Sdk.Metadata;

namespace GenericConverter
{
    public class GuidFromString : ConvertFromString
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="T:System.Object" /> class.
        /// </summary>
        /// <exception cref="ArgumentNullException"><paramref name="convertFromString" /> is <see langword="null" />.</exception>
        public GuidFromString(IConvertFromString convertFromString)
            : base(convertFromString)
        {
            if (convertFromString == null)
            {
                throw new ArgumentNullException(nameof(convertFromString));
            }
        }

        public override bool AmIResponsible =>OutputType != null &&  OutputType.Name == "Guid"|| OutputAttributeTypeCode.Equals(AttributeTypeCode.Uniqueidentifier);

        protected override object InnerOutput(string input)
        {
            return input == null ? (object) null : Guid.ParseExact(input, "D");
        }
    }
}