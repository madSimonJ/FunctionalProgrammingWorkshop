namespace FunctionalCSharpWorkshop
{
    public class Execises02_HigherOrderFunctions
    {
        // Task 1 - Write a function that returns a count of how many times a given value has 
        // appeared in a given property.  E.g. the value "9" appears 3 times in PropertyTwo.
        // This function should take two parameters:
        // 1. a Func delegate which is used to select the property to examine
        // 2. the value of that property you want to count
            
            //fill parameters into this function
            public int GetCountOfValue()
            {
                throw new NotImplementedException();
            }
            
             
            private readonly IEnumerable<DataContainer> _SampleData = [
                new DataContainer {
                    PropertyOne = "1",
                    PropertyTwo  = "9",
                    PropertyThree = "4"
                },
                  new DataContainer {
                    PropertyOne = "1",
                    PropertyTwo  = "9",
                    PropertyThree = "5"
                },
                new DataContainer {
                    PropertyOne = "2",
                    PropertyTwo  = "9",
                    PropertyThree = "5"
                },
                new DataContainer {
                    PropertyOne = "2",
                    PropertyTwo  = "1",
                    PropertyThree = "5"
                }              

            ];

        public readonly record struct DataContainer
        {
            public string PropertyOne { get; init; }
            public string PropertyTwo { get; init; }

            public string PropertyThree { get; init; }

        }
        
    }
}