using System;
using Microsoft.Xrm.Sdk;

namespace GenericConverter.Internal
{
    public class MoneyFromString : ConvertFromString
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="T:System.Object" /> class.
        /// </summary>
        /// <exception cref="ArgumentNullException"><paramref name="convertFromString" /> is <see langword="null" />.</exception>
        public MoneyFromString(IConvertFromString convertFromString)
            : base(convertFromString)
        {
            if (convertFromString == null)
            {
                throw new ArgumentNullException(nameof(convertFromString));
            }
        }

        public override bool AmIResponsible => OutputType.Name == "Money";

        public override object InnerOutput(string input)
        {
            return input == null ? null : new Money(Convert.ToDecimal(input));
        }
    }
}