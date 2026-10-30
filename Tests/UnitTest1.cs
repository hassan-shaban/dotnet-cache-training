namespace DotNetCacheTraining.Tests;

public class UnitTest1
{
    [Fact]
    public void Add_TwoNumbers_ReturnsCorrectResult()
    {
        // Arrange
        int firstNumber = 10;
        int secondNumber = 20;

        // Act
        int result = firstNumber + secondNumber;

        // Assert
        Assert.Equal(30, result);
    }
}
