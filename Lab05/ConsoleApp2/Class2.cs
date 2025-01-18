namespace ConsoleApp1
{
    // class declaration
    public class Person
    {
        // constructor
        public Person(string firstName, string lastName, DateTime birthDate, string emailAddress)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
            this.EmailAddress = emailAddress;
        }

        // properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string EmailAddress { get; set; }



        // method
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
        public double GetAge(){ return (DateTime.Now - this.BirthDate).TotalDays / 365;}

        public bool IsAdult() { return (DateTime.Now - this.BirthDate).TotalDays > 18;}
    }
}
