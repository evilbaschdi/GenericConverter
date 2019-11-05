using System;
using Microsoft.Xrm.Sdk;

namespace GenericConverter.Internal
{
    public class OptionSetValueFromString : ConvertFromString
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="T:System.Object" /> class.
        /// </summary>
        /// <exception cref="ArgumentNullException"><paramref name="convertFromString" /> is <see langword="null" />.</exception>
        public OptionSetValueFromString(IConvertFromString convertFromString)
            : base(convertFromString)
        {
            if (convertFromString == null)
            {
                throw new ArgumentNullException(nameof(convertFromString));
            }
        }

        public override bool AmIResponsible => OutputType.Name == "OptionSetValue";

        protected override object InnerOutput(string input)
        {
            return input == null ? null : new OptionSetValue(Convert.ToInt32(input));
        }
    }
}