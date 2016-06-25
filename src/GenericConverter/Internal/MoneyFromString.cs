using System;
using Microsoft.Xrm.Sdk;

namespace GenericConverter.Internal
{
    public class MoneyFromString : ConvertFromString
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="T:System.Object" /> class.
        /// </summary>
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
            if (input == null)
            {
                return null;
            }

            return new Money(Convert.ToDecimal(input));
        }
    }
}