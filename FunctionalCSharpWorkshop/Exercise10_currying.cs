namespace FunctionalCSharpWorkshop;

public class Exercise10_currying
{
    public int Add10(int x) => x + 10;
    public int Add20(int x) => x + 20;
    public int Add30(int x) => x + 30;
    
    // Replace these three functions above with a single binary add function that uses currying.
    [Fact]
    public void Exercise01_a_()
    {
        var answer = Add10(50);
        Assert.Equal(60, answer);
    }
    
    [Fact]
    public void Exercise01_b_()
    {
        var answer = Add20(50);
        Assert.Equal(70, answer);
    }
    
    [Fact]
    public void Exercise01_c_()
    {
        var answer = Add30(50);
        Assert.Equal(80, answer);
    }


    // using Currying to convert this single function into a series of 
    // simpler unary functions with just the message as parameter
    // e.g. LogLevel1 (or whatever you'd like to call level 1).  Call the
    // app whatever you'd like, then write a test to confirm it works
    public void Log(string appName, int logLevel, string message)
    {
        Console.WriteLine($"{DateTime.Now.ToShortDateString()}{appName}-{logLevel}-{message}");
    }
    
}