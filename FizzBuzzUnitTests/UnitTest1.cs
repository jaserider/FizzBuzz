namespace FizzBuzzUnitTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(4, "4")]
        [InlineData(7, "7")]
        [InlineData(11, "11")]
        [InlineData(101, "101")]
        public void TestsWhichReturnTheOriginalNumber(int number, string expectedResult)
        {
            string result = FizzBuzz.FizzBuzz.GetStringFromNumber(number);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(99)]
        public void TestsWhichReturnFizz(int number)
        {
            string result = FizzBuzz.FizzBuzz.GetStringFromNumber(number);
            Assert.Equal("Fizz", result);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(100)]
        public void TestsWhichReturnBuzz(int number)
        {
            string result = FizzBuzz.FizzBuzz.GetStringFromNumber(number);
            Assert.Equal("Buzz", result);
        }
        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(75)]
        [InlineData(90)]
        public void TestsWhichReturnFizzbuzz(int number)
        {
            string result = FizzBuzz.FizzBuzz.GetStringFromNumber(number);
            Assert.Equal("Fizzbuzz", result);
        }
    }
}