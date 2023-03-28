namespace myAPI.Tests
{
    public class NumberCheckerTests
    {
        [Theory]
        [InlineData(2, true)]
        [InlineData(3, false)]
        [InlineData(0, true)]
        public void IsEven_ReturnsCorrectResult(int number, bool expectedResult)
        {
            // Arrange
            var numberChecker = new NumberChecker();

            // Act
            var result = numberChecker.IsEven(number);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}