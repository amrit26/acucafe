using AcuCafe.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AcuCafe.Tests
{
    [TestClass]
    public class ValidationTests
    {
        [TestMethod]
        public void IsUserInputValid_True()
        {
            var validInput = Validation.IsInputValid("1");
            Assert.IsTrue(validInput);
        }

        [TestMethod]
        public void IsUserInputValid_False()
        {
            var invalidInput = Validation.IsInputValid("number");
            Assert.IsFalse(invalidInput);
        }

        [TestMethod]
        public void IsDrinkSelectedOnTheList_True()
        {
            var validInput = Validation.IsDrinkSelectedOnTheList("1");
            Assert.IsTrue(validInput);
        }

        [TestMethod]
        public void IsDrinkSelectedOnTheList_False()
        {
            var invalidInput = Validation.IsDrinkSelectedOnTheList("9");
            Assert.IsFalse(invalidInput);
        }

        [TestMethod]
        public void IsToppingSelectedOnTheList_True()
        {
            var validInput = Validation.IsToppingSelectedOnTheList("1");
            Assert.IsTrue(validInput);
        }

        [TestMethod]
        public void IsToppingSelectedOnTheList_False()
        {
            var invalidInput = Validation.IsToppingSelectedOnTheList("9");
            Assert.IsFalse(invalidInput);
        }
    }
}
