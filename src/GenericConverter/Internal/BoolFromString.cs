using System;

namespace GenericConverter.Internal
{
    public class BoolFromString : ConvertFromString
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="T:System.Object" /> class.
        /// </summary>
        /// <exception cref="ArgumentNullException"><paramref name="convertFromString"/> is <see langword="null" />.</exception>
        public BoolFromString(IConvertFromString convertFromString)
            : base(convertFromString)
        {
            if (convertFromString == null)
            {
                throw new ArgumentNullException(nameof(convertFromString));
            }
        }

        public override bool AmIResponsible => OutputType.Name == "Boolean";

        public override object InnerOutput(string input)
        {
            if (input == null)
            {
                return null;
            }

            var b = false;

            switch (input.ToUpper())
            {
                case "0":
                case "F":
                case "FALSE":
                case "NO":
                    b = false;
                    break;
                case "1":
                case "T":
                case "TRUE":
                case "YES":
                    b = true;
                    break;
            }

            return b;
        }
    }
}