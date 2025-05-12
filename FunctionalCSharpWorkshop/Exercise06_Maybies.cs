using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunctionalCSharpWorkshop
{
    public class Exercise06_Maybies
    {
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }


        // Exercise 1 - rework these next 2 functions to use Maybe<Person> instead of simply Person

        public static Person PersonGetter(int personId)
        {
            if(personId == 6)
                return new Person {
                    FirstName = "Patrick",
                    LastName = "McGoohan",
                };
            
            throw new Exception("I am not a number!");
        }

        public static string NameGetter(int personId)
        {
            var person = PersonGetter(personId);
            return person.FirstName + " " + person.LastName;
        }



        // Exercise 2 - Use Maybe<SuperHero> and calls to .Bind to improve the following


        public SuperHero GetSuperHero(int id)
        {
            var datastore = new [] 
            {
                new SuperHero
                {
                    Id = 1,
                    Name = "Iron Man",
                    SecretIdentity = "Tony Stark"
                },
                new SuperHero
                {
                    Id = 2,
                    Name = "Thor",
                    SecretIdentity = "Donald Blake"
                }
            };

            return datastore.single(x => x.Id == id);

        }

        public string GetSuperheroDescription(int id)
        {
            var hero = GetSuperHero(id);

            var description = $"{hero.Name} ({hero.SecretIdentity})"; 
            return description;
        }



        //Exercise 3 - same again.  re-write this using Maybe and Bind

        public Film GetFilm(int id) =>
			id switch
			{
            1 => new Film {
                Id = 1,
                Name = "Bladerunner",
                Director = 1
             },
             2 => new Film
             {
                Id = 2,
                Name = "Amelie",
                Director = 2
             },
             3 => new Film{
                Id = 3,
                Name = "Once Upon a Time in the West",
                Director = 3
             },
             4 => new Film
             {
                Id = 4,
                Name = "Excalibur",
                Director = 4
             }
			};

        public FilmPerson GetPerson(int id) => id switch
		{
            1 => new FilmPerson
            {
                Id = 1,
                Name = "Ridley Scott"
            },
            2 => new FilmPerson
            {
                Id = 2,
                Name = "Jean-Pierre Jeunet"
            },
            3 => new FilmPerson
            {
                Id = 3,
                Name = "Sergio Leone"
            }
		};

            public string GetDirectorsName(int Id)
            {
                var film = GetFilm(Id);
                var director = GetPerson(film.Director);
                return director.Name;
            }
      



    }


    public class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Director { get; set; }
    }

    public class FilmPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class SuperHero
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SecretIdentity { get; set; }
    }
}

