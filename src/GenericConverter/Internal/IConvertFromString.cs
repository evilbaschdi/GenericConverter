using System;

namespace GenericConverter.Internal
{
    /// <summary>
    ///     Interface for convertFromString chain of responsibility.
    /// </summary>
    public interface IConvertFromString
    {
        IConvertFromString NextChain { get; }

        bool AmIResponsible { get; }

        object Output(string input, Type outputType);
    }
}