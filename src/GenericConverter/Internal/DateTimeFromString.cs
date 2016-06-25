using System;
using System.Globalization;

namespace GenericConverter.Internal
{
    public class DateTimeFromString : ConvertFromString
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="T:System.Object" /> class.
        /// </summary>
        public DateTimeFromString(IConvertFromString convertFromString)
            : base(convertFromString)
        {
            if (convertFromString == null)
            {
                throw new ArgumentNullException(nameof(convertFromString));
            }
        }

        public override bool AmIResponsible => OutputType.Name == "DateTime";

        public override object InnerOutput(string input)
        {
            if (input == null)
            {
                return null;
            }

            return DateTime.ParseExact(input, "yyyyMMddHHmmss", CultureInfo.InvariantCulture);
            ;
        }
    }
}