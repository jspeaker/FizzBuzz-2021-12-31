namespace FizzBuzzLibrary.Strategies;

public class IntegerAsStringFactory
{
    public static IIntegerAsString Instance(int value)
    {
        if (value % (3 * 5) == 0) return new IntegerToFizzBuzzStrategy();
        if (value % 5 == 0) return new IntegerToBuzzStrategy();
        if (value % 3 == 0) return new IntegerToFizzStrategy();
        return new IntegerToStringStrategy(value);
    }
}