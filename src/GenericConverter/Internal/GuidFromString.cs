using System;

namespace GenericConverter.Internal
{
    public class GuidFromString : ConvertFromString
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="T:System.Object" /> class.
        /// </summary>
        public GuidFromString(IConvertFromString convertFromString)
            : base(convertFromString)
        {
            if (convertFromString == null)
            {
                throw new ArgumentNullException(nameof(convertFromString));
            }
        }

        public override bool AmIResponsible => OutputType.Name == "Guid";

        public override object InnerOutput(string input)
        {
            if (input == null)
            {
                return null;
            }

            return Guid.ParseExact(input, "D");
        }
    }
}