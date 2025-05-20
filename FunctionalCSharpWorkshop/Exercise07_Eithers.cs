namespace FunctionalCSharpWorkshop
{
    public class Exercise07_Eithers
    {

        public string EvilFizzBuzz(int number)
        {
            return number switch
            {
                _ when number % 3 == 0 => throw new Exception("fizz"),
                _ when number % 5 == 0 => throw new Exception("buzz"),
                _ => string.Empty
            };
        }

        public string composeFizzBuzzLine(int number)
        {
            var text = EvilFizzBuzz(number);
            return $"{number}  {text}";
        }

        public string MakeFizzBuzz(int number)
        {
            var lines = Enumerable.Range(1, number)
                .Select(composeFizzBuzzLine);
            var returnVaule = string.Join(Environment.NewLine, lines);
            return returnVaule;
        }
        
        [Fact]
        public void Exercise01()
        {
            var fizzBuzzes = MakeFizzBuzz(20);
            var expectedFizzBuzzes = @"1  
2  
3  fizz
4  
5  buzz
6  fizz
7  
8  
9  fizz
10  buzz
11  
12  fizz
13  
14  
15  fizz
16  
17  
18  fizz
19  
20  buzz";
            
            Assert.Equal(fizzBuzzes, expectedFizzBuzzes);

        }
        
        
        
        
        [Theory]
        [InlineData(1, "Oslo")]
        [InlineData(2, "This was supposed to be the UK.  Oh well")]
        [InlineData(3, "No, it's not Sydney!  It's Canberra")]

        public void Exercise02(int countryId, string expectedText)
        {
            var capitalCityText = GetCapitalCity(countryId);
            Assert.Equal(expectedText, capitalCityText);
        }

        // Provide an implementation for this function so that either the capital city
        // or an error message is returned.  There are a few ways this could be done
        // but make sure to use Either and Bind to provide a fault tolerant flow of 
        // functions.
        // The return types will have to be changed in each case to wrap them in an Either or Maybe
        public string GetCapitalCity(int Id)
        {
            throw new NotImplementedException();
        }



        public Country GetCountry(int id) =>
            id switch
            {
                1 => new Country
                {
                    Id = 1,
                    Name = "Norway",
                    CapitalCityId = 1
                },
                2 => throw new Exception("This was supposed to be the UK.  Oh well"),
                3 => new Country
                {
                    Id = 3,
                    Name = "Australia",
                    CapitalCityId = 3
                }
            };


        public City GetCity(int id) =>
            id switch
            {
                1 => new City
                {
                    Id = 1,
                    Name = "Oslo"
                },
                2 => new City
                {
                    Id = 2,
                    Name = "London"
                },
                3 => throw new Exception("No, it's not Sydney!  It's Canberra")

            };




        public class Country
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int CapitalCityId { get; set; }
        }

        public class City
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

    }
}