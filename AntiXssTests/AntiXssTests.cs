using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegexValidation;

namespace AntiXssTests
{
    [TestClass]
    public class AntiXssTests
    {
        [TestMethod]
        public void AlphaValidationAnyLength()
        {
            Assert.IsTrue(AntiXssValidation.IsAlphabetic("aaAAjj", 0, false));
            Assert.IsTrue(AntiXssValidation.IsAlphabetic("aaAAjjrr", 0, false));
            Assert.IsTrue(AntiXssValidation.IsAlphabetic("this string".Replace(" ", ""), 0, false));
            Assert.IsFalse(AntiXssValidation.IsAlphabetic("this string", 0, false));
            Assert.IsFalse(AntiXssValidation.IsAlphabetic("aa1AAjjrr", 0, false));
            Assert.IsFalse(AntiXssValidation.IsAlphabetic("", 0, false));
            Assert.IsFalse(AntiXssValidation.IsAlphabetic(" ", 0, false));
        }

        [TestMethod]
        public void AlphaValidationSpecificLength()
        {
            Assert.IsTrue(AntiXssValidation.IsAlphabetic("aaa", 3, false));
            Assert.IsFalse(AntiXssValidation.IsAlphabetic("aa", 3, false));
            Assert.IsFalse(AntiXssValidation.IsAlphabetic("", 3, false));
            Assert.IsFalse(AntiXssValidation.IsAlphabetic(" ", 3, false));
        }

        [TestMethod]
        public void AlphaValidationLengthRange()
        {
            Assert.IsFalse(AntiXssValidation.IsAlphabetic("a", 2, 3, false));
            Assert.IsTrue(AntiXssValidation.IsAlphabetic("aa", 2, 3, false));
            Assert.IsTrue(AntiXssValidation.IsAlphabetic("aaa", 2, 3, false));
            Assert.IsFalse(AntiXssValidation.IsAlphabetic("aaaa", 2, 3, false));
        }

        [TestMethod]
        public void AlphaValidationWithNullInput()
        {
            Assert.IsTrue(AntiXssValidation.IsAlphabetic(null, 1, true));
            Assert.IsTrue(AntiXssValidation.IsAlphabetic(null, 1, 2, true));
            Assert.IsFalse(AntiXssValidation.IsAlphabetic(null, 1, false));
            Assert.IsFalse(AntiXssValidation.IsAlphabetic(null, 1, 2, false));
        }

        [TestMethod]
        public void AlphaValidationException()
        {
            var message = "Input is invalid.";

            try
            {
                var success = AntiXssValidation.IsAlphabetic("!a", 2, false, false);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(message, e.Message);
            }

            try
            {
                var success = AntiXssValidation.IsAlphabetic(null, 2, false, false);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(message, e.Message);
            }
            Assert.IsTrue(AntiXssValidation.IsAlphabetic("aa", 2, false, false));
            Assert.IsTrue(AntiXssValidation.IsAlphabetic(null, 2, true, false));
            Assert.IsFalse(AntiXssValidation.IsAlphabetic("!a", 2, false, true));
            Assert.IsFalse(AntiXssValidation.IsAlphabetic(null, 2, false, true));
        }

        [TestMethod]
        public void AlphaValidationLengthRangeException()
        {
            var message = "Input is invalid.";

            try
            {
                var success = AntiXssValidation.IsAlphabetic("!aa", 2, 4, false, false);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(message, e.Message);
            }

            try
            {
                var success = AntiXssValidation.IsAlphabetic(null, 2, 4, false, false);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(message, e.Message);
            }
            Assert.IsTrue(AntiXssValidation.IsAlphabetic("aaa", 2, 4, false, false));
            Assert.IsTrue(AntiXssValidation.IsAlphabetic(null, 2, 4, true, false));
            Assert.IsFalse(AntiXssValidation.IsAlphabetic("!a", 2, 4, false, true));
            Assert.IsFalse(AntiXssValidation.IsAlphabetic(null, 2, 4, false, true));
        }

        [TestMethod]
        public void NumValidationAnyLength()
        {
            Assert.IsTrue(AntiXssValidation.IsNumeric("112233", 0, false));
            Assert.IsTrue(AntiXssValidation.IsNumeric("1122", 0, false));
            Assert.IsTrue(AntiXssValidation.IsNumeric("111 222".Replace(" ", ""), 0, false));
            Assert.IsFalse(AntiXssValidation.IsNumeric("111 222", 0, false));
            Assert.IsFalse(AntiXssValidation.IsNumeric("12a32", 0, false));
            Assert.IsFalse(AntiXssValidation.IsNumeric("", 0, false));
            Assert.IsFalse(AntiXssValidation.IsNumeric(" ", 0, false));
        }

        [TestMethod]
        public void NumValidationSpecificLength()
        {
            Assert.IsTrue(AntiXssValidation.IsNumeric("111", 3, false));
            Assert.IsFalse(AntiXssValidation.IsNumeric("11", 3, false));
            Assert.IsFalse(AntiXssValidation.IsNumeric("", 3, false));
            Assert.IsFalse(AntiXssValidation.IsNumeric(" ", 3, false));
        }

        [TestMethod]
        public void NumValidationLengthRange()
        {
            Assert.IsFalse(AntiXssValidation.IsNumeric("1", 2, 3, false));
            Assert.IsTrue(AntiXssValidation.IsNumeric("11", 2, 3, false));
            Assert.IsTrue(AntiXssValidation.IsNumeric("111", 2, 3, false));
            Assert.IsFalse(AntiXssValidation.IsNumeric("1111", 2, 3, false));
        }

        [TestMethod]
        public void NumValidationException()
        {
            var message = "Input is invalid.";

            try
            {
                var success = AntiXssValidation.IsNumeric("aa", 2, false, false);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(message, e.Message);
            }

            try
            {
                var success = AntiXssValidation.IsNumeric(null, 2, false, false);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(message, e.Message);
            }
            Assert.IsTrue(AntiXssValidation.IsNumeric("11", 2, false, false));
            Assert.IsTrue(AntiXssValidation.IsNumeric(null, 2, true, false));
            Assert.IsFalse(AntiXssValidation.IsNumeric("1a", 2, false, true));
            Assert.IsFalse(AntiXssValidation.IsNumeric(null, 2, false, true));
        }

        [TestMethod]
        public void NumValidationLengthRangeException()
        {
            var message = "Input is invalid.";

            try
            {
                var success = AntiXssValidation.IsNumeric("1aa", 2, 4, false, false);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(message, e.Message);
            }

            try
            {
                var success = AntiXssValidation.IsNumeric(null, 2, 4, false, false);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(message, e.Message);
            }
            Assert.IsTrue(AntiXssValidation.IsNumeric("111", 2, 4, false, false));
            Assert.IsTrue(AntiXssValidation.IsNumeric(null, 2, 4, true, false));
            Assert.IsFalse(AntiXssValidation.IsNumeric("1a", 2, 4, false, true));
            Assert.IsFalse(AntiXssValidation.IsNumeric(null, 2, 4, false, true));
        }

        [TestMethod]
        public void NumValidationWithNullInput()
        {
            Assert.IsTrue(AntiXssValidation.IsNumeric(null, 1, true));
            Assert.IsTrue(AntiXssValidation.IsNumeric(null, 1, 2, true));
            Assert.IsFalse(AntiXssValidation.IsNumeric(null, 1, false));
            Assert.IsFalse(AntiXssValidation.IsNumeric(null, 1, 2, false));
        }

        [TestMethod]
        public void AlphaNumValidationAnyLength()
        {
            Assert.IsTrue(AntiXssValidation.IsAlphaNumeric("aa1A1j", 0, false));
            Assert.IsTrue(AntiXssValidation.IsAlphaNumeric("aaAA1j1r", 0, false));
            Assert.IsTrue(AntiXssValidation.IsAlphaNumeric("this str1ng".Replace(" ", ""), 0, false));
            Assert.IsFalse(AntiXssValidation.IsAlphaNumeric("this str1ng", 0, false));
            Assert.IsFalse(AntiXssValidation.IsAlphaNumeric("aa$AA1jrr", 0, false));
            Assert.IsFalse(AntiXssValidation.IsAlphaNumeric("", 0, false));
            Assert.IsFalse(AntiXssValidation.IsAlphaNumeric(" ", 0, false));
        }

        [TestMethod]
        public void AlphaNumValidationSpecificLength()
        {
            Assert.IsTrue(AntiXssValidation.IsAlphaNumeric("1aa", 3, false));
            Assert.IsFalse(AntiXssValidation.IsAlphaNumeric("1a", 3, false));
            Assert.IsFalse(AntiXssValidation.IsAlphaNumeric("", 3, false));
            Assert.IsFalse(AntiXssValidation.IsAlphaNumeric(" ", 3, false));
        }

        [TestMethod]
        public void AlphaNumValidationLengthRange()
        {
            Assert.IsFalse(AntiXssValidation.IsAlphaNumeric("a", 2, 3, false));
            Assert.IsTrue(AntiXssValidation.IsAlphaNumeric("a1", 2, 3, false));
            Assert.IsTrue(AntiXssValidation.IsAlphaNumeric("a11", 2, 3, false));
            Assert.IsFalse(AntiXssValidation.IsAlphaNumeric("a111", 2, 3, false));
        }

        [TestMethod]
        public void AlphaNumValidationWithNullInput()
        {
            Assert.IsTrue(AntiXssValidation.IsAlphaNumeric(null, 1, true));
            Assert.IsTrue(AntiXssValidation.IsAlphaNumeric(null, 1, 2, true));
            Assert.IsFalse(AntiXssValidation.IsAlphaNumeric(null, 1, false));
            Assert.IsFalse(AntiXssValidation.IsAlphaNumeric(null, 1, 2, false));
        }

        [TestMethod]
        public void AlphaNumValidationException()
        {
            var message = "Input is invalid.";

            try
            {
                var success = AntiXssValidation.IsAlphaNumeric("a1!", 3, false, false);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(message, e.Message);
            }

            try
            {
                var success = AntiXssValidation.IsAlphaNumeric(null, 2, false, false);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(message, e.Message);
            }
            Assert.IsTrue(AntiXssValidation.IsAlphaNumeric("aa1", 3, false, false));
            Assert.IsTrue(AntiXssValidation.IsAlphaNumeric(null, 3, true, false));
            Assert.IsFalse(AntiXssValidation.IsAlphaNumeric("!a1", 3, false, true));
            Assert.IsFalse(AntiXssValidation.IsAlphaNumeric(null, 3, false, true));
        }

        [TestMethod]
        public void AlphaNumValidationLengthRangeException()
        {
            var message = "Input is invalid.";

            try
            {
                var success = AntiXssValidation.IsAlphaNumeric("!a1", 2, 4, false, false);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(message, e.Message);
            }

            try
            {
                var success = AntiXssValidation.IsAlphaNumeric(null, 2, 4, false, false);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(message, e.Message);
            }
            Assert.IsTrue(AntiXssValidation.IsAlphaNumeric("aa1", 2, 4, false, false));
            Assert.IsTrue(AntiXssValidation.IsAlphaNumeric(null, 2, 4, true, false));
            Assert.IsFalse(AntiXssValidation.IsAlphaNumeric("!a1", 2, 4, false, true));
            Assert.IsFalse(AntiXssValidation.IsAlphaNumeric(null, 2, 4, false, true));
        }

        [TestMethod]
        public void AlphaNumValidationMethod()
        {
            Assert.IsTrue(AntiXssValidation.IsValidAlphanumeric("aa123", 2, 3, true, false));
            Assert.IsTrue(AntiXssValidation.IsValidAlphanumeric("bb123", 2, 3, true, false));
            Assert.IsTrue(AntiXssValidation.IsValidAlphanumeric("111aa", 2, 3, false, false));
            Assert.IsTrue(AntiXssValidation.IsValidAlphanumeric(null, 2, 3, false, true));
            Assert.IsFalse(AntiXssValidation.IsValidAlphanumeric(null, 2, 3, false, false));
        }

        [TestMethod]
        public void AlphaNumValidationMethodWithInvalidInput()
        {
            // Arrange
            var invalidInput = new string[] { "", " ", "a", "aa", "a1", "11", "a123", "aa12a", "11aaa" };
            bool result = true;

            // Act
            foreach (string input in invalidInput)
            {
                if (AntiXssValidation.IsValidAlphanumeric(input.Trim(), 2, 3, true, false))
                {
                    result = false;
                }
            }

            // Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void AlphaNumValidationMethodWithNullInput()
        {
            //Assert
            Assert.IsTrue(AntiXssValidation.IsValidAlphanumeric(null, 1, 2, true, true));
            Assert.IsFalse(AntiXssValidation.IsValidAlphanumeric(null, 1, 2, true, false));
        }

        [TestMethod]
        public void AlphaNumValidationMethodException()
        {
            var message = "Input is invalid.";

            try
            {
                var success = AntiXssValidation.IsValidAlphanumeric("aa123", 2, 3, false, false, false);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(message, e.Message);
            }

            try
            {
                var success = AntiXssValidation.IsValidAlphanumeric(null, 2, 3, false, false, false);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(message, e.Message);
            }

            Assert.IsTrue(AntiXssValidation.IsValidAlphanumeric("aa123", 2, 3, true, false, false));
            Assert.IsTrue(AntiXssValidation.IsValidAlphanumeric(null, 2, 3, true, true, false));
            Assert.IsFalse(AntiXssValidation.IsValidAlphanumeric("aa123", 2, 3, false, false, true));
            Assert.IsFalse(AntiXssValidation.IsValidAlphanumeric(null, 2, 3, false, false, true));
        }

        [TestMethod]
        public void CustomValidation()
        {
            //Assert
            Assert.IsTrue(AntiXssValidation.IsValid("aa", "^[a-z]{2}$", false));
            Assert.IsFalse(AntiXssValidation.IsValid("aaa", "^[a-z]{2}$", false));
            Assert.IsTrue(AntiXssValidation.IsValid(null, "^[a-z]{2}$", true));
            Assert.IsFalse(AntiXssValidation.IsValid(null, "^[a-z]{2}$", false));
        }

        [TestMethod]
        public void CustomValidationException()
        {
            var message = "Input is invalid.";

            try
            {
                var success = AntiXssValidation.IsValid("a", "^[a-z]{2}$", false, false);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(message, e.Message);
            }

            try
            {
                var success = AntiXssValidation.IsValid(null, "^[a-z]{2}$", false, false);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(message, e.Message);
            }

            Assert.IsTrue(AntiXssValidation.IsValid("aa", "^[a-z]{2}$", false, false));
            Assert.IsFalse(AntiXssValidation.IsValid("aaa", "^[a-z]{2}$", false, true));
            Assert.IsTrue(AntiXssValidation.IsValid(null, "^[a-z]{2}$", true, false));
            Assert.IsFalse(AntiXssValidation.IsValid(null, "^[a-z]{2}$", false, true));
        }
    }
}
