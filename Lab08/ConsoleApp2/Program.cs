using System.Collections.Generic;

namespace ConsoleApp2{
    internal class Program{
        static List <Book> books = new List<Book>();
        static void Main(string[] args)
        {
            string choice;
            do{
                Console.Clear();
                System.Console.WriteLine("1. Add Book");
                System.Console.WriteLine("2. Display Books");
                System.Console.WriteLine("3. Search Book");
                System.Console.WriteLine("4. Exit");
                choice = Console.ReadLine();
                switch(choice)
                {
                    case "1":
                        add_book();
                        break;
                    case "2":
                        display_books();
                        break;
                    case "3":
                        search_book();
                        break;
                    case "4":
                        break;
                    default:
                        System.Console.WriteLine("Invalid choice! Press enter to continue");
                        Console.ReadLine();
                        break;
                }
            }while (!choice.Equals("4"));
        }
        static void add_book(){
            Console.Clear();
            System.Console.WriteLine("Enter book title: ");
            string bookTitle = Console.ReadLine();

            System.Console.WriteLine("Enter author: ");
            string bookAuthor = Console.ReadLine();
            
            System.Console.WriteLine("Enter year: ");
            int bookYear = Convert.ToInt32(Console.ReadLine());
            
            books.Add(new Book {Title = bookTitle, Author = bookAuthor, Year = bookYear});
            Console.WriteLine("Book added successfully! Press enter to continue...");
            Console.ReadLine();
        }

        static void display_books(){
            Console.Clear();
            System.Console.WriteLine("What do you want to sort by?");
            System.Console.WriteLine("1. Title");
            System.Console.WriteLine("2. Author");
            System.Console.WriteLine("3. Year");
            string sortBy = Console.ReadLine();
            IEnumerable<Book> sortedBooks = books;

            switch(Convert.ToInt32(sortBy))
            {
                case 1:
                    sortedBooks = books.OrderBy(b => b.Title);
                    break;
                case 2:
                    sortedBooks = books.OrderBy(b => b.Author);
                    break;
                case 3:
                    sortedBooks = books.OrderBy(b => b.Year);
                    break;
                default:
                    System.Console.WriteLine("Invalid choice! Press enter to continue...");
                    Console.ReadLine();
                    break;
            }
            Console.Clear();
            Console.WriteLine("List of sorted books");
            foreach(var book in sortedBooks){
                System.Console.WriteLine(book);
            }
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }

        static void search_book(){
            Console.Clear();
            System.Console.WriteLine("What do you want to search by?");
            System.Console.WriteLine("1. Title");
            System.Console.WriteLine("2. Author");
            System.Console.WriteLine("3. Year");
            string searchBy = Console.ReadLine();

            Console.WriteLine("Enter your search term:");
            string searchTerm = Console.ReadLine();
            IEnumerable<Book> searchedBooks = searchBy switch{
                "1" => books.Where(b => b.Title.Contains(searchTerm)),
                "2" => books.Where(b => b.Author.Contains(searchTerm)),
                "3" => books.Where(b => b.Year.ToString().Contains(searchTerm)),
                _ => Enumerable.Empty<Book>(),
            };

            Console.Clear();
            if (searchedBooks.Any()){
                Console.WriteLine("List of matching books");
                foreach(var book in searchedBooks){
                    System.Console.WriteLine(book);
                }}

            else{
                System.Console.WriteLine("No matching books found!");
            }
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }
    }
    public class Book{
        public Book()
        {

        }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return $"{Title} by {Author}, {Year}";
        }
    }

}