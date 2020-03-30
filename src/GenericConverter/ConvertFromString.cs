using System;
using Microsoft.Xrm.Sdk.Metadata;

namespace GenericConverter
{
    /// <summary>
    ///     Abstract class for convertFromString chain of responsibility.
    /// </summary>
    public abstract class ConvertFromString : IConvertFromString
    {
        protected AttributeTypeCode OutputAttributeTypeCode;
        protected Type OutputType;

        /// <summary>
        ///     Initializes a new instance of the <see cref="T:System.Object" /> class.
        /// </summary>
        protected ConvertFromString(IConvertFromString convertFromString)
        {
            if (convertFromString == null)
            {
                //   throw new ArgumentNullException(nameof(convertFromString));
            }

            NextChain = convertFromString;
        }

        public IConvertFromString NextChain { get; }

        public abstract bool AmIResponsible { get; }

        public object Output(string input, Type outputType)
        {
            if (input == null)
            {
                return null;
            }

            OutputType = outputType;
            return AmIResponsible ? InnerOutput(input) : NextChain.Output(input, outputType);
        }

        public object Output(string input, AttributeTypeCode outAttributeTypeCode)
        {
            if (input == null)
            {
                return null;
            }

            OutputAttributeTypeCode = outAttributeTypeCode;
            return AmIResponsible ? InnerOutput(input) : NextChain.Output(input, outAttributeTypeCode);
        }

        protected abstract object InnerOutput(string input);
    }
}