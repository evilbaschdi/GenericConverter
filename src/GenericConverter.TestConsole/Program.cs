using Microsoft.Xrm.Sdk;

namespace GenericConverter.TestConsole;

public class Program
{
    public static void Main()
    {
        CompositionRoot.Run();
        Console.ReadLine();
    }
}

public interface IOptionSetValue : IValue<OptionSetValue>
{
}

public class GetEnumFromOptionSetValue<T> : IValue<T>
    where T : struct, IConvertible
{
    private readonly IOptionSetValue _optionSetValue;
    private readonly T _fallbackEnum;

    public GetEnumFromOptionSetValue(IOptionSetValue optionSetValue, T fallbackEnum)

    {
        _optionSetValue = optionSetValue ?? throw new ArgumentNullException(nameof(optionSetValue));
        _fallbackEnum = fallbackEnum;
    }

    public T Value
    {
        get
        {
            if (!typeof(T).IsEnum)
            {
                throw new ArgumentException("T must be an enumerated type");
            }

            var value = _optionSetValue.Value?.Value ?? 0;

            return Enum.IsDefined(typeof(T), value) ? (T)Enum.ToObject(typeof(T), value) : _fallbackEnum;
        }
    }
}