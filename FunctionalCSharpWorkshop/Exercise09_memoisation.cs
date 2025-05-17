using System.Security.Cryptography;

namespace FunctionalCSharpWorkshop;

public class Exercise09_memoisation
{
    public static long CalculateFibonnachiNumber(int number)
    {
        return number switch
        {
            0 => 0,
            1 => 1,
            _ => CalculateFibonnachiNumber(number - 1) + CalculateFibonnachiNumber(number - 2)
        };
    }
    
    // Use Memoisation, so that this test doesn't take the life of the universe to run!
    [Theory]
    [InlineData(1, 1)]
    [InlineData(2, 1)]
    [InlineData(3, 2)]
    [InlineData(4, 3)]
    [InlineData(5, 5)]
    [InlineData(6, 8)]
    [InlineData(50, 12586269025)]
    public void Exercise01(int number, long expected)
    {
        var actual = CalculateFibonnachiNumber(number);
        Assert.Equal(expected, actual);
    }
}