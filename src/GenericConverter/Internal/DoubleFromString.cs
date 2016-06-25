using System;

namespace GenericConverter.Internal
{
    public class DoubleFromString : ConvertFromString
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="T:System.Object" /> class.
        /// </summary>
        public DoubleFromString(IConvertFromString convertFromString)
            : base(convertFromString)
        {
            if (convertFromString == null)
            {
                throw new ArgumentNullException(nameof(convertFromString));
            }
        }

        public override bool AmIResponsible => OutputType.Name == "Double";

        public override object InnerOutput(string input)
        {
            if (input == null)
            {
                return null;
            }

            return Convert.ToDouble(input);
        }
    }
}