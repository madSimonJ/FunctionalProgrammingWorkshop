namespace FunctionalCSharpWorkshop
{
    public class Execises02_HigherOrderFunctions
    {
        // Task 1 - write a pure functional-style report function which takes a single higher-order function
        // as a parameter, which can be used to select which property is to be summarised.
        // the summary consists of a row for each possible value of the selected property, followed by a count of 
        // how many times that property occured.  e.g. for PropertyTwo:
        // 9 - 3
        // 1 - 1
        //this should be returned as a single string with newline characters





            private readonly IEnumerable<DataContainer> _SampleData = new [] {
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

            };

        public class DataContainer
        {
            public string PropertyOne { get; set; }
            public string PropertyTwo { get; set; }

            public string PropertyThree { get; set; }

        }
        
    }
}