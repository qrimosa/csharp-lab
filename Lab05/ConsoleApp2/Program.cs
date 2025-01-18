using ConsoleApp1;
using System.Linq;

Coords point1 = new Coords(2.0, 5.0);
Console.WriteLine(point1);

Coords point2 = new Coords(3.0, 2.0); ;

if (point1.Equals(point2))
    Console.WriteLine("Equal structs");
else
    Console.WriteLine("Different structs");

//zadanie1
int[] numbers = { 10, 20, 30, 40, 50, 60 };
Console.WriteLine(LenghtOfTheLine());
Console.WriteLine(MinMaxVal(numbers));
static double LenghtOfTheLine()
{
    Coords point3 = new Coords(2.0, 5.0);
    Coords point4 = new Coords(3.0, 2.0);
    return Math.Sqrt((point3.X - point4.X) * (point3.X - point4.X) + (point3.Y - point4.Y) * (point3.Y - point4.Y));
}

//zadanie2
static (int Max, int Min) MinMaxVal(int[] arr)
{
    Console.WriteLine(arr.Max());
    Console.WriteLine(arr.Min());
    return (arr.Max(), arr.Min());
}

//zadanie3
Person person1 = new Person("John", "Doe", new DateTime(1999, 12, 12), "marat.iskhakov@microsoft.wsei.edu.pl");
person1.FirstName = "John";
person1.LastName = "Doe";
person1.BirthDate = new DateTime(1999, 12, 12);
person1.EmailAddress = "maratiskhakov9@gmail.com";  
Console.WriteLine($"Person= {person1.GetFullName()} {person1.BirthDate} {person1.EmailAddress}");
Console.WriteLine($"Person1 is {person1.GetAge()} years old");
if (person1.IsAdult())
{
    Console.WriteLine("Person1 is an adult!");
}
else
{
    Console.WriteLine("Person1 is not an adult!");
}

