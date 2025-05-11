using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Xunit.Sdk;

namespace FunctionalCSharpWorkshop;

public class Extercises01
{
    [Fact]
    public void Exercise01()
    {
        // Write a function that converts strings of digits into the names of each number in turn

        var input = 85261287;
        var result = ConvertToNumberNames(input);
        Assert.Equal("eight five two six one two eight seven", result);

        string ConvertToNumberNames(int input)
        {
            throw new NotImplementedException();
        }
    }

    [Fact]
    public void Exercise02()
    {
        // Write a function that takes a string containing ( and ) characters.  Add one for each (, deduct one for each ).
        // calculate the final result.  Based on Advent of Code 2015, Day One.
        // https://adventofcode.com/2015/day/1 - for more examples

        var input = "(()(()(";
        var result = CalculateAnswer(input);
        Assert.Equal(3, result);
        

        int CalculateAnswer(string input)
        {
            throw new NotImplementedException();
        }
    }

    [Fact]
    public void Exercise03()
    {
        // Write a function that determins whether there are two consecutive numbers in an array of intgers
        // e.g. [1, 4, 6, 7, 9] contains a consecutive pair of numbers (6 and 7), but [1, 4, 6, 9] does not

        var input = new [] {1, 4, 5, 6, 7, 9};
        var result = DoesContainConsecutiveNumbers(input);
        Assert.True(result);

        bool DoesContainConsecutiveNumbers(IEnumerable<int> input)
        {
            throw new NotImplementedException();
        }

    }

    [Fact]
    public void Exercise04()
    {
        // Write a function that calculates the sum of values each of a, b and c - but with only a single
        // iteration of the source array

        var input = new []
        {
            new Numbers 
            {
                A = 3,
                B = 64,
                C = 91    
            },
            new Numbers 
            {
                A = 2,
                B = 9,
                C = 57    
            },
            new Numbers 
            {
                A = 93,
                B = 14,
                C = 52    
            }
        };

        var result = CalculateTotals(input);

        Assert.Equal(98, result.A);
        Assert.Equal(87, result.B);
        Assert.Equal(200, result.C);

        
        Numbers CalculateTotals(IEnumerable<Numbers> input)
        {
            throw new NotImplementedException();
        }


    }

    [Fact]
    public void Exercise05()
    {
        var suits = new []  { "Hearts", "Spades", "Clubs", "Diamonds"};
        var values = new [] { "A", "K", "Q", "J", "10", "9", "8", "7", "6", "5", "4", "3", "2"};

        // Write a function that generates a list of all cards in a standard 52-deck of cards (excepting the jokers)
        // then randomly select 5 to form a poker hand, and determines whether or not the hand is a flush
        // i.e. all cards have the same suit


    }

    [Fact]
    public void Exercise06()
    {
        // Solve FizzBuzz using LINQ.  Generate the first 20 lines, joined into a single string with 
        // newlines between each line.  As a reminder - Each line consists of a number between 1 and
        // 20, then either no further text, or the word "fizz" if the nuber is divisible by 3 and 
        // the word "buzz" if the number is divisible by 5.
    }


    public static async Task Blah()
    {
        async Task<int> GetAnInteger()
        {
            await Task.Delay(1);
            return 6;
        }

        async Task<string> GetAString(Task<int> i)
        {
            var j =  await i;
            return j.ToString();
        }
		
        var result = await await GetAnInteger().ContinueWith(x => x);

    }

        private class Numbers
        {
            public int A { get; init; }
            public int B { get; init; }

            public int C { get; init; }

        }

}