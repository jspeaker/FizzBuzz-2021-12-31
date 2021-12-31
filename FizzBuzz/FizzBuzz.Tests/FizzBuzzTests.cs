using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod, TestCategory("Unit")]
        public void GivenIntegerThatIsNotMultipleOfThreeOrFive_WhenAskingForString_ThenItShouldReturnIntegerAsString()
        {
            // arrange
            FizzBuzzString subject = new(1);

            // act
            string actual = subject.AsString();

            // assert
            actual.Should().Be("1");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenIntegerThatIsMultipleOfThree_WhenAskingForString_ThenItShouldReturnFizz()
        {
            // arrange
            FizzBuzzString subject = new(3);

            // act
            string actual = subject.AsString();

            // assert
            actual.Should().Be("Fizz");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenIntegerThatIsMultipleOfFive_WhenAskingForString_ThenItShouldReturnBuzz()
        {
            // arrange
            FizzBuzzString subject = new(5);

            // act
            string actual = subject.AsString();

            // assert
            actual.Should().Be("Buzz");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenIntegerThatIsMultipleOfThreeAndFive_WhenAskingForString_ThenItShouldReturnFizzBuzz()
        {
            // arrange
            FizzBuzzString subject = new(15);

            // act
            string actual = subject.AsString();

            // assert
            actual.Should().Be("FizzBuzz");
        }
    }

    public class FizzBuzzString
    {
        private readonly IIntegerAsString _integerAsString;

        public FizzBuzzString(int value) : this(IntegerAsStringFactory.Instance(value)) {}

        public FizzBuzzString(IIntegerAsString integerAsString) => _integerAsString = integerAsString;

        public string AsString() => _integerAsString.AsString();
    }

    public interface IIntegerAsString
    {
        string AsString();
    }

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

    public static class FizzBuzzText
    {
        public const string Fizz = "Fizz";
        public const string Buzz = "Buzz";
        public static string FizzBuzz = $"{Fizz}{Buzz}";
    }

    public class IntegerToFizzBuzzStrategy : IIntegerAsString
    {
        public string AsString() => FizzBuzzText.FizzBuzz;
    }

    public class IntegerToBuzzStrategy : IIntegerAsString
    {
        public string AsString() => FizzBuzzText.Buzz;
    }

    public class IntegerToFizzStrategy : IIntegerAsString
    {
        public string AsString() => FizzBuzzText.Fizz;
    }

    public class IntegerToStringStrategy : IIntegerAsString
    {
        private readonly int _value;

        public IntegerToStringStrategy(int value) => _value = value;

        public string AsString() => _value.ToString();
    }
}