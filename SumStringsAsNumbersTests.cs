using NUnit.Framework;

namespace SumStringsAsNumbers.nUnitTests
{
    public class SumStringsAsNumbersTests
    {

        private Kata _kata { get; set; } = null!;

        [SetUp]
        public void Setup()
        {
            _kata = new Kata();
        }

        [TestCase("123", "456")]
        [TestCase("287", "292")]
        [TestCase("272", "307")]
        [TestCase("37", "542")]
        public void sumStrings_EqualTest(string a, string b)
        {
            // Assign
            //string a = "123";
            //string b = "456";

            // Act
            string sum = Kata.sumStrings(a, b);

            // Assert
            Assert.AreEqual("579", sum);

            //Assert.Pass();
        }

        [TestCase("2", "5")]
        [TestCase("", "7")]
        public void sumStrings_EqualTests2(string a, string b)
        {
            // Act
            string sum = Kata.sumStrings(a, b);

            // Assert
            Assert.AreEqual("7", sum);
        }

        [TestCase("712569312664357328695151392", "8100824045303269669937")]
        public void sumStrings_EqualTests3(string a, string b)
        {
            // Act
            string sum = Kata.sumStrings(a, b);

            // Assert
            Assert.AreEqual("712577413488402631964821329", sum);
        }

        [TestCase("50095301248058391139327916261", "81055900096023504197206408605")]
        public void sumStrings_EqualTests4(string a, string b)
        {
            // Act
            string sum = Kata.sumStrings(a, b);

            // Assert
            Assert.AreEqual("131151201344081895336534324866", sum);
        }


    }
}