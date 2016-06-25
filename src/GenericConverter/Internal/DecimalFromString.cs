using System;

namespace GenericConverter.Internal
{
    public class DecimalFromString : ConvertFromString
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="T:System.Object" /> class.
        /// </summary>
        public DecimalFromString(IConvertFromString convertFromString)
            : base(convertFromString)
        {
            if (convertFromString == null)
            {
                throw new ArgumentNullException(nameof(convertFromString));
            }
        }

        public override bool AmIResponsible => OutputType.Name == "Decimal";

        public override object InnerOutput(string input)
        {
            if (input == null)
            {
                return null;
            }

            return Convert.ToDecimal(input);
        }
    }
}