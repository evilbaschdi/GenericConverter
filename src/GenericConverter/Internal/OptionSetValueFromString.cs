using System;
using Microsoft.Xrm.Sdk;

namespace GenericConverter.Internal
{
    public class OptionSetValueFromString : ConvertFromString
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="T:System.Object" /> class.
        /// </summary>
        public OptionSetValueFromString(IConvertFromString convertFromString)
            : base(convertFromString)
        {
            if (convertFromString == null)
            {
                throw new ArgumentNullException(nameof(convertFromString));
            }
        }

        public override bool AmIResponsible => OutputType.Name == "OptionSetValue";

        public override object InnerOutput(string input)
        {
            if (input == null)
            {
                return null;
            }

            return new OptionSetValue(Convert.ToInt32(input));
        }
    }
}