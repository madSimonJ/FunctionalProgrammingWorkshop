using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunctionalCSharpWorkshop
{
    public class Exercises03_Map
    {
        [Fact]
        public void Exercise01()
        {
            var output = ConvertToCentigrade(100);
            Assert.Equal("37.78 degrees centigrade", output);

            // Change this to functional-style code by using Map
            static string ConvertToCentigrade(decimal fahrenheitTemp)
            {
                var centigrade = fahrenheitTemp - 32;
                centigrade /= 1.8M;
                centigrade = Math.Round(centigrade, 2);
                var returnValue = $"{centigrade} degrees centigrade";
                return returnValue;
            }
        }



        [Fact]
        public void Exercise02()
        {
            var input = "To be or not to be.  That is the question";
            var result = ReverseSentence(input);
            Assert.Equal("That is the question.  To be or not to be", result);

            //  Change this to be less awkward by using Map to make a neat flow of operations in logical order
            static string ReverseSentence(string input)
            {
                return string.Join(".  " , input.Split(".  ").Reverse().ToArray() );
            }
        }


        [Fact]
        public void Exercise03()
        {
            // rewrite the function "CalculateGeekHorrorScope" so that it uses local functions
            // and a Pipe to bind them all together into a function
            var horrorScope = CalculateGeekHorrorScope(new DateTime(1984, 8, 18, 0, 0, 0));
            Assert.Equal("What's the point of being grown up if you can't be childish sometimes", horrorScope);
        }
	public static string CalculateGeekHorrorScope(DateTime dob)
	{
		
		var month = dob.Month;
		var starSign = month switch
		{
				1 => GeekStarSign.CaptainPicard,
				2 => GeekStarSign.CaptainPicard,
				3 => GeekStarSign.LukeSkywalker,
				4 => GeekStarSign.LukeSkywalker,
				5 => GeekStarSign.SpiderMan,
				6 => GeekStarSign.SpiderMan,
				7 => GeekStarSign.TomBaker,
				8 => GeekStarSign.TomBaker,
				9 => GeekStarSign.Pikachu,
				10 => GeekStarSign.Pikachu,
				_ => GeekStarSign.Athena
		};
		var horrorScope = starSign switch
		{
				GeekStarSign.CaptainPicard => "Remember to tip your Ressikan flute player",
				GeekStarSign.LukeSkywalker => "Father's day is coming up.  Think carefully about what to get him",
				GeekStarSign.SpiderMan => "Happiness is overrated",
				GeekStarSign.TomBaker => "What's the point of being grown up if you can't be childish sometimes",
				GeekStarSign.Pikachu => "Pika Pika",
				_ => "Never, ever say you're better at anything than Athena.  It won't end well..."
		};
		return horrorScope;


	}

        [Fact]
        public void Exercise04()
        {
            var t = new Triangle(10, 10);
            var h = CalculateHypotenuse(t);
            Assert.Equal(14.142M, h);

            static decimal CalculateHypotenuse(Triangle triangle)
            {
                // Use a Fork Combinator here
                throw new NotImplementedException();
            }
        }

        [Fact]
        public void Exercise05()
        {
            var result = GetFirstNonNullString();
            Assert.Equal("Donald Duck", result);

            // Re-write this with an Alt combinator
            // Either with a fixed number of alternative data sources
            // or with params to find the first valid from an indefinite list of 
            // sources
            string GetFirstNonNullString()
            {
                var s1 = GetName1();
                if(!string.IsNullOrWhiteSpace(s1))
                {
                    return s1;
                }

                var s2 = GetName2();
                if(!string.IsNullOrWhiteSpace(s2))
                {
                    return s2;
                }

                return GetName3();
            }
            string GetName1() => null;
            string GetName2() => null;
            string GetName3() => "Donald Duck";
        }
    }
}


    public enum GeekStarSign
	{
		CaptainPicard,
		LukeSkywalker,
		SpiderMan,
		TomBaker,
		Pikachu,
		Athena
	}

    public readonly record struct Triangle
    {
        public Triangle(decimal a, decimal b)
        {
            this.A = a;
            this.B = b;
        }

        public decimal A { get; }
        public decimal B { get; }
    }

