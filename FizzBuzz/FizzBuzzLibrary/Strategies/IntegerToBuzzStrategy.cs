using FizzBuzzLibrary.Texts;

namespace FizzBuzzLibrary.Strategies;

public class IntegerToBuzzStrategy : IIntegerAsString
{
    public string AsString() => FizzBuzzText.Buzz;
}