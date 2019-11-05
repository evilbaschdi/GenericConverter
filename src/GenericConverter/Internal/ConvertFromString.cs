using System;

namespace GenericConverter.Internal
{
    /// <summary>
    ///     Abstract class for convertFromString chain of responsibility.
    /// </summary>
    public abstract class ConvertFromString : IConvertFromString
    {
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

        protected abstract object InnerOutput(string input);
    }
}