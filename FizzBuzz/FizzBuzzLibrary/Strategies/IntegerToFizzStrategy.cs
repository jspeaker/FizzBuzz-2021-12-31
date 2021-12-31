using FizzBuzzLibrary.Texts;

namespace FizzBuzzLibrary.Strategies;

public class IntegerToFizzStrategy : IIntegerAsString
{
    public string AsString() => FizzBuzzText.Fizz;
}