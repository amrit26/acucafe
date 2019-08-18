using AcuCafe.Logic;
using NUnit.Framework;

namespace AcuCafe.Tests
{
    [TestFixture]
    public class ValidationTests
    {
        [TestCase("1")]
        [TestCase("4")]
        [TestCase("7")]
        [Test]
        public void IsUserInputValid_True(string userInput)
        {
            var validInput = Validation.IsInputValid(userInput);
            Assert.IsTrue(validInput);
        }

        [TestCase("number")]
        [TestCase("-10")]
        [TestCase("0")]
        [Test]
        public void IsUserInputValid_False(string userInput)
        {
            var invalidInput = Validation.IsInputValid(userInput);
            Assert.IsFalse(invalidInput);
        }

        [TestCase("1")]
        [TestCase("4")]
        [TestCase("7")]
        [Test]
        public void IsDrinkSelectedOnTheList_True(string userInput)
        {
            var validInput = Validation.IsDrinkSelectedOnTheList(userInput);
            Assert.IsTrue(validInput);
        }

        [TestCase("number")]
        [TestCase("-10")]
        [TestCase("9")]
        [Test]
        public void IsDrinkSelectedOnTheList_False(string userInput)
        {
            var invalidInput = Validation.IsDrinkSelectedOnTheList(userInput);
            Assert.IsFalse(invalidInput);
        }

        [TestCase("1")]
        [TestCase("3")]
        [TestCase("5")]
        [Test]
        public void IsToppingSelectedOnTheList_True(string userInput)
        {
            var validInput = Validation.IsToppingSelectedOnTheList(userInput);
            Assert.IsTrue(validInput);
        }

        [TestCase("number")]
        [TestCase("-10")]
        [TestCase("7")]
        [Test]
        public void IsToppingSelectedOnTheList_False(string userInput)
        {
            var invalidInput = Validation.IsToppingSelectedOnTheList(userInput);
            Assert.IsFalse(invalidInput);
        }
    }
}
