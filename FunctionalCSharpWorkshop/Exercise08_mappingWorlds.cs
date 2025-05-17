namespace FunctionalCSharpWorkshop;

public class Exercise08_mappingWorlds
{
    // Write a series of functions that use both Either and Maybe elevated types, then a single flow of 
    // Bind calls that maps between them, using whatever method you'd prefer.
    // Feel free to use your own imagination, but here's my suggestion:
    // N.B - feel free also to change the types from Either to Maybe and vice versa
    // But you should hopefully end up with a flow that involves both at some point
    // at the very least, given no "DB" operations are involved, GetMiddleName should remain 
    // with Maybe<string> as its return type.  Anything representing a virtual
    // call to an external data source should be wrapped in an Either to capture the
    // error, however
    
    // public Either<string> GetMothersMiddleName(Maybe<int> personId)
    // {
        
    // }

    // public Either<Person> GetPerson(Maybe<int> personId)
    // {
        
    // }
    
    // public Maybe<string> GetMiddleName(Maybe<Person> p)
    // {

    // }

    // public readonly record struct Person
    // {
    // public int PersonId { get; init; }
     //   public Maybe<string> MiddleName { get; init; }
    //    public int MotherId { get; init; }
    //}
    
    
}