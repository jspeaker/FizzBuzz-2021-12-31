using FizzBuzzLibrary.Strategies;

namespace FizzBuzzLibrary;

public class FizzBuzz
{
    private readonly IIntegerAsString _strategy;

    public FizzBuzz(int value) : this(IntegerAsStringFactory.Instance(value)) {}

    public FizzBuzz(IIntegerAsString strategy) => _strategy = strategy;

    public string AsString() => _strategy.AsString();
}