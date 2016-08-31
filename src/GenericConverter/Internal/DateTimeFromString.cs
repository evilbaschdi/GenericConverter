using System;
using System.Globalization;

namespace GenericConverter.Internal
{
    public class DateTimeFromString : ConvertFromString
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="T:System.Object" /> class.
        /// </summary>
        /// <exception cref="ArgumentNullException"><paramref name="convertFromString" /> is <see langword="null" />.</exception>
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
            return input == null ? (object) null : DateTime.ParseExact(input, "yyyyMMddHHmmss", CultureInfo.InvariantCulture);
        }
    }
}