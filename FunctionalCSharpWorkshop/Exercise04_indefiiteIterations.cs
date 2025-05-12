namespace FunctionalCSharpWorkshop
{
    public class Exercise04_indefiiteIterations
    {
        [Fact]
        public void Exercise01()
        {
            // Returning to Advent of Code 2015, Day One.  Part Two
            // Iterate through the values for the current floor in the input
            // below, and find the first character that brings you to
            // floor -1.  In this case, the sequence of numbers is 
            // 0 (starting value),1,2,1,2,3,2,1,0,-1,0,1
            // the final value is 1, but I want the number of the iteration that first reached -1
            // that is (with the first character being position 0 and reaching floor 1 from floor 0) position 9
            // https://adventofcode.com/2015/day/1 - for more examples

            var input = "(()(())))((";
            var result = CalculateAnswer(input);
            Assert.Equal(9, result);

            static int CalculateAnswer(string input)
            {
                throw new NotImplementedException();
            }
        }

        [Fact]
        public void Exercise02()
        {
            // This is a validation exercise, prompting the user until they enter a valid response
            // rewrite this in any functiona style you like
            var validInput = GetNumericInput(new MyFakeConsole());
            Assert.Equal(1, validInput);

            static int GetNumericInput(MyFakeConsole console)
            {

                while(true)
                {
                    var input = console.GetInput();
                    var validInt = int.TryParse(input, out var parsedValue);
                    if(validInt)
                        return parsedValue;
                }
            }

        }

        public class MyFakeConsole
        {
            private readonly string[] Inputs = [
                "one", 
                "0ne",
                "On3",
                "1",
                "2",
                "3"];
            

            // Yes, this isn't functional style code.  It's for the test though.
            private int counter;
            public string GetInput()
            {
                var returnValue = Inputs[counter];
                counter++;
                return returnValue;
            }
        }
    }
}