using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunctionalCSharpWorkshop
{

    // re-write this into a discriminated union with Product as the type, containing Game or Book
    // then write a function using a switch expression as its body that will write a Product to string
    // with the correct fields for each type.  Local functions might be useful.

    public readonly record struct Product
    {
        public int Id { get; init; }
        public string Title { get; init; }
        public string Subtitle { get; init; }
        public ProductType Type { get; init; } 
        public int MinimunPlayers { get; init; }
        public int MaximumPlayers { get; init; }
        public int NumberOfPages { get; init; }
        public string Author { get; init; }

    }

    public enum ProductType
    {
        Book,
        Game
    }
}