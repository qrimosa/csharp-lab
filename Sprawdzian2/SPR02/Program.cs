using System;
using System.Collections.Generic;
using System.Linq;

namespace SPR02{
    class Program{
        public static void Main(string[] args){
            //ZADANIE1
            PointThreeD point1 = new PointThreeD(1.5, 5.75, -7.0);
            System.Console.WriteLine("ZADANIE1");
            System.Console.WriteLine($"Odleglość punktu od początku układu współrzędnych: {point1.GetDistanceFromOrigin()}\r\n");
            
            //ZADANIE2
            
            Adult john = new Adult("John");
            Adult jane = new Adult("Jane");
            Child kevin = new Child("Kevin");
            Child mike = new Child("Mike");
            Child wendy = new Child("Wendy");

            kevin.Mother = jane;
            kevin.Father = john;

            mike.Mother = jane;
            mike.Father = john;

            wendy.Mother = jane;
            wendy.Father = john;

            john.AddChild(kevin);
            john.AddChild(mike);
            john.AddChild(wendy);

            jane.AddChild(kevin);
            jane.AddChild(mike);
            jane.AddChild(wendy);

            System.Console.WriteLine("ZADANIE2");
            System.Console.WriteLine($"Dorośli {john.Name} i {jane.Name} mający {john.CountChildren()} dzieći: {mike.Name}, {kevin.Name} oraz {wendy.Name}\r\n");
            
            //ZADANIE3
            Console.WriteLine("ZADANIE3");
            Human humanAdult = new Adult("adult1");
            Console.WriteLine(humanAdult.EatSnack());

            Human childAdult = new Child("child1");
            Console.WriteLine($"{childAdult.EatSnack()}\r\n");

            //ZADANIE4
            System.Console.WriteLine("ZADANIE4");
            Human[] humans = { new Adult("Mark"), new Child("Filip"), new Child("Adam")};
            foreach (var h in humans)
            {
               if(h is ISinger singer){
                 Console.WriteLine($"{h.Name} śpiewa: {singer.Sing()}");
                 continue;
               }
               else{
                 Console.WriteLine($"{h.Name} nie potrafi śpiewać.");
                 continue;
               }
            }

            //ZADANIE5
            System.Console.WriteLine("");
            Singers<Child> childrenSingers = new Singers<Child>();
            childrenSingers.Add(kevin);
            childrenSingers.Add(mike);
            childrenSingers.Add(wendy);
            System.Console.WriteLine("ZADANIE5");

            foreach(var child in childrenSingers){
                System.Console.WriteLine($"{child.Name} śpiewa: {child.Sing()}");
            }

            //ZADANIE6
            System.Console.WriteLine("");
            System.Console.WriteLine("ZADANIE6");
            var Book1 = new Book { Title = "Ulysses", Author = "James Joyce", YearPublished = 1922 };
            var Book2 = new Book { Title = "Lolita", Author = "Vladimir Nabokov", YearPublished = 1955 };
            var Book3 = new Book { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", YearPublished = 1925 };
            var Book4 = new Book { Title = "In Search of Lost Time", Author = "Marcel Proust", YearPublished = 1913 };
            List<Book> books = new List<Book>{Book1,Book2,Book3,Book4};
            var authors = books.Select(b => b.Author).Distinct().OrderBy(a => a).ToList();
            Console.WriteLine("Autorzy w kolejności alfabetycznej:");
            foreach (var author in authors)
            {
                Console.WriteLine(author);
            }
            var favBook = new Book { Title = "1984", Author = "George Orwell", YearPublished = 1949 };books.Add(favBook);
            var Booksolder100 = books.Where(b => DateTime.Now.Year - b.YearPublished > 100).Select(b => b.Title).ToList();
            Console.WriteLine("\nKsiążki starsze niż 100 lat:");
            foreach (var title in Booksolder100)
            {
                Console.WriteLine(title);
            }
            var OldBook = books.OrderBy(b => b.YearPublished).First();
            books.Remove(OldBook);
        }
    }
        public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearPublished { get; set; }
    }
}