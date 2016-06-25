using System;

namespace GenericConverter.Internal
{
    /// <summary>
    ///     Abstract class for convertFromString chain of responsibility.
    /// </summary>
    public abstract class ConvertFromString : IConvertFromString
    {
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

        protected string Input;
        protected Type OutputType;

        public object Output(string input, Type outputType)
        {
            if (input == null)
            {
                return null;
            }
            Input = input;
            OutputType = outputType;
            return AmIResponsible ? InnerOutput(input) : NextChain.Output(input, outputType);
        }

        public abstract object InnerOutput(string input);
    }
}