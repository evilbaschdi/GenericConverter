﻿using Microsoft.Xrm.Sdk.Metadata;

// ReSharper disable UnusedMemberInSuper.Global
namespace GenericConverter;

/// <summary>
///     Interface for convertFromString chain of responsibility.
/// </summary>
public interface IConvertFromString
{
    bool AmIResponsible { get; }
    IConvertFromString NextChain { get; }

    object Output(string input, Type outputType);

    object Output(string input, AttributeTypeCode outputAttributeTypeCode);
}