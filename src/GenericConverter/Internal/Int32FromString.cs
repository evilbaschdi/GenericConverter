using System;

namespace GenericConverter.Internal
{
    public class Int32FromString : ConvertFromString
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="T:System.Object" /> class.
        /// </summary>
        public Int32FromString(IConvertFromString convertFromString)
            : base(convertFromString)
        {
            if (convertFromString == null)
            {
                throw new ArgumentNullException(nameof(convertFromString));
            }
        }

        public override bool AmIResponsible => OutputType.Name == "Int32";

        public override object InnerOutput(string input)
        {
            if (input == null)
            {
                return null;
            }

            return Convert.ToInt32(input);
        }
    }
}