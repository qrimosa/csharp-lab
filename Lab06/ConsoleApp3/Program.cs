using ConsoleApp3;
using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Anna", "Kowalska") { BirthDate = new DateTime(2007, 4, 20) };
            
            Person person2 = new Person("Marat", "Iskhakov") { BirthDate = new DateTime(2006, 8, 1) };

            Animal pet = new Animal("Burek", "dog");

            person.Partner = person2;
            person2.Partner = person;

            Appearance wyglad = new Appearance("Green", "Blonde", false);
            person.Wyglad = wyglad;


            Person.Relate(person2, person);
            
            person.AdoptAPet(pet);

            Console.WriteLine($"{person.GetFullName()} adopted a pet.");
            Console.WriteLine($"The pet's name is {person.Pet.Name} and it is a {person.Pet.Species}.");
            Console.WriteLine($"{person.GetFullName()}'s partner is {person2.GetFullName()}");
            Console.WriteLine($"{person2.GetFullName()} has {person.Wyglad.HairColor} hair color, {person.Wyglad.EyesColor} eyes color and {person.Wyglad.HasFreckles} freckles");

            if (person.Wyglad.HasFreckles)
            {
                Console.WriteLine($"{person2.GetFullName()} has {person.Wyglad.HairColor} hair, {person.Wyglad.EyesColor} eyes and has freckles");
            }
            else {
                Console.WriteLine($"{person2.GetFullName()} has {person.Wyglad.HairColor} hair, {person.Wyglad.EyesColor} eyes and does not has freckles");
            }
        }
    }
}
