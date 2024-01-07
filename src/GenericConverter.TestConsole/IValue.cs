namespace GenericConverter.TestConsole;

public interface IValue<out T>
{
    T Value { get; }
}