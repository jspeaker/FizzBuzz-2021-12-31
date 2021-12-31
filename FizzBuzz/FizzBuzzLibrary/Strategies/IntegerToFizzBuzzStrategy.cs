using FizzBuzzLibrary.Texts;

namespace FizzBuzzLibrary.Strategies;

public class IntegerToFizzBuzzStrategy : IIntegerAsString
{
    public string AsString() => FizzBuzzText.FizzBuzz;
}