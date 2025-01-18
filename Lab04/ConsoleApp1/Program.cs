using ConsoleApp1;
using System.Text.RegularExpressions;
namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(QuadraticEquation());
            Console.WriteLine(QuadraticEquation(1.0, 2.5, 3.2, 4.999));

            double x = 10;
            double y = 20;
            Swap(ref x, ref y);
            Console.WriteLine($"x = {x}, y = {y}");

            Multiply(1.0, 2.0);
            Multiply(1.0, 2.0, 3.0);
            Multiply(1.0, 2.0, 3.0, 4.0, 5.0);

            PrintDayOfTheWeek(DayOfTheWeek.Sunday);
            DateTimeFunc(DateTime.Now);
            DivizionEx();
            PasswordValid("aslkjuU123_");
        }

        static double QuadraticEquation(double x = 0.0, double a = 1.0, double b = 1.0, double c = 1.0)
        {
            return a * x * x + b * x + c;
        }
        static void Swap(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }
        static double Multiply(double a, double b)
        {
            return a * b;
        }
        static double Multiply(double a, double b, double c)
        {
            return a * b * c;
        }
        static double Multiply(params double[] a)
        {
            double result = 1.0;
            foreach (double x in a)
            { result *= x; }
            return result;
        }
        static void PrintDayOfTheWeek(DayOfTheWeek day)
        {
            Console.WriteLine(day);
            Console.WriteLine((int)day);
            if ((int)day >= 6) {
                Console.WriteLine("weekend");
            }
            else {
                Console.WriteLine("not a weekend");
            }
        }
        
        enum DayOfTheWeek
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void DateTimeFunc(DateTime dt)
        {
            string dany = $"{dt.Day}...{dt.Month}...{dt.Year}...{dt.Hour}:{dt.Minute}:{dt.Second}...{dt.DayOfWeek}";
            dany = dany.ToUpper();
            Console.WriteLine(dany);
        }
        static double DivizionEx(double x = 10.0, double y = 0.0)
        {
            try
            {
                return (double)x / (double)y;
            }
            catch (DivideByZeroException) 
            {
                return 0;
            }
        }
        static void SetYourNewPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
                throw new ArgumentException("your password cant be empty");
            
            if (password.Length < 10)
                throw new FormatException("your password is too short");

            if (!Regex.IsMatch(password, "[A-Z]"))
                throw new FormatException("Password must contain at least one uppercase letter.");

            if (!Regex.IsMatch(password, "[a-z]"))
                throw new FormatException("Password must contain at least one lowercase letter.");

            if (!Regex.IsMatch(password, "[0-9]"))
                throw new FormatException("Password must contain at least one digit.");

            if (!Regex.IsMatch(password, "[^a-zA-Z0-9]"))
                throw new FormatException("Password must contain at least one special character.");
        }
        static void PasswordValid(string password)
        {
            try
            {
                SetYourNewPassword(password);
                Console.WriteLine("your password is set successfully");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("error" + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("error" + ex.Message);
            }
        }
    }
}