using System.Runtime.CompilerServices;

namespace ConsoleApp3
{
    // class declaration
    public class Person
    {
        public readonly static Person NewlyBornChild = new Person("", "") { BirthDate = DateTime.Today };
        // constructors
        public Person()
        {

        }
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        // properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string EmailAddress { get; set; }
        public int? Height { get; set; }
        public Person Partner { get; set; }
        public Animal Pet { get; set; }
        public Appearance Wyglad { get; set; }


        // method
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public int GetAge()
        {
            return DateTime.Now.Year - this.BirthDate.Year;
        }

        public bool IsAdult()
        {
            return this.GetAge() > 18;
        }

        public static void Relate(Person p1, Person p2)
        {
            p1.Partner = p2;
            p2.Partner = p1;
        }
        public void AdoptAPet(Animal pet)
        {
            this.Pet = pet;
        }
    }
}