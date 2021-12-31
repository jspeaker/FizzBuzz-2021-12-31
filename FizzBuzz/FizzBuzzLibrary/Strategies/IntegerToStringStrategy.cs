namespace FizzBuzzLibrary.Strategies;

public class IntegerToStringStrategy : IIntegerAsString
{
    private readonly int _value;

    public IntegerToStringStrategy(int value) => _value = value;

    public string AsString() => _value.ToString();
}