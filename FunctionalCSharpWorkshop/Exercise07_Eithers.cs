using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunctionalCSharpWorkshop
{
    public class Exercise07_Eithers
    {
        [Theory]
        [InlineData(1, "Oslo")]
        [InlineData(2, "This was supposed to be the UK.  Oh well")]
        [InlineData(3, "No, it's not Sydney!  It's Canberra")]

        public void Exercise01(int countryId, string expectedText)
        {
            var capitalCityText = GetCapitalCity(countryId);
            Assert.Equal(expectedText, capitalCityText);
        }

        // Provide an implementation for this function so that either the capital city
        // or an error message is returned.  There are a few ways this could be done
        // but make sure to use Either and Bind to provide a fault tolerant flow of 
        // functions
        public string GetCapitalCity(int Id)
        {
            throw new NotImplementedException();
        }



     public Country GetCountry(int id) =>
        1 => new Country {
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

    public City GetCity(int id) =>
        1 => new City {
            Id =1,
            Name = "Oslo"
        },
        2 => new City {
            Id = 2,
            Name = "London"
        },
        3 => throw new Exception("No, it's not Sydney!  It's Canberra"),)

    }



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