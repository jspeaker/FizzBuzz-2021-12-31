using FizzBuzzLibrary;
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
            FizzBuzzLibrary.FizzBuzz subject = new(2);

            // act
            string actual = subject.AsString();

            // assert
            actual.Should().Be("2");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenIntegerThatIsMultipleOfThree_WhenAskingForString_ThenItShouldReturnFizz()
        {
            // arrange
            const int three = 3;
            FizzBuzzLibrary.FizzBuzz subject = new(3 * three);

            // act
            string actual = subject.AsString();

            // assert
            actual.Should().Be("Fizz");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenIntegerThatIsMultipleOfFive_WhenAskingForString_ThenItShouldReturnBuzz()
        {
            // arrange
            const int five = 5;
            FizzBuzzLibrary.FizzBuzz subject = new(4 * five);

            // act
            string actual = subject.AsString();

            // assert
            actual.Should().Be("Buzz");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenIntegerThatIsMultipleOfThreeAndFive_WhenAskingForString_ThenItShouldReturnFizzBuzz()
        {
            // arrange
            const int three = 3;
            const int five = 5;
            FizzBuzzLibrary.FizzBuzz subject = new(4 * three * five);

            // act
            string actual = subject.AsString();

            // assert
            actual.Should().Be("FizzBuzz");
        }
    }
}