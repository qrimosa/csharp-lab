//zadanie 1 
using System.Collections.Generic;

int n = 10;
do
{
    Console.WriteLine(n);
    n--;
} while  (n >= 0);

//zadanie 2 
string haslo = "koniec";
string a;
do
{
    a = Console.ReadLine();
} while (a != haslo);

//zadanie 3
int num  = 0;
while (num <= 100)
{
    if (num % 2 == 0)
    {
        Console.WriteLine(num);
    }
    num++;
}

//zadanie 4
for (int i = 1; i <= 15; i++)
{
    Console.WriteLine(i * i);
}

//zadanie 5 
List<int> numbers = new() { 4, 25, 35, 42, 55, 78, 99, 101 };
foreach (int i in numbers)
{
    if (i % 7 == 0)
    {
        Console.WriteLine($"{i} ");
    }
}

//zadanie 6
foreach (int i in numbers)
{
    if (i % 7 == 0)
    {
        Console.WriteLine(i);
        break;
    }   
}

//zadanie 7
double[] doubleArray = new double[20];
for (int i = 0; i < 20; i++)
{
    doubleArray[i] =  Math.Sqrt(i);
}
for (int i = 0; i < doubleArray.Length; i++)
{
    Console.WriteLine($"{i} = {doubleArray[i]}");
}

//zadanie 8 
int[,] matrix = new int[3, 4];
int z = 1;
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        matrix[i, j] = z;
        z++;
    }
}
for (int j = 0; j < 4; j++)
{
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

//zadanie 10
static void BigLetter(string word)
{
    Console.WriteLine(word.ToUpper());
    return;
}
BigLetter("idontcare");

//zadanie 11
static void MatrixFunc(int x, int y)
{
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            Console.Write("$ ");
        }
        Console.WriteLine();
    }
}
MatrixFunc(3, 4);

//zadanie 12 
static void IntToStr(int x)
{
    if (x % 2 == 0)
    {
        Console.WriteLine("even");
    }
    else {
        Console.WriteLine("odd");
    }
}
IntToStr(3);


//zadanie 13
static void Main()
{
    int n = WczytajZKlawiatury("Podaj liczbę wierszy (n): ");
    int m = WczytajZKlawiatury("Podaj liczbę kolumn (m): ");

    char[,] tablica = WypelnijTablice(n, m);
    WyswietlTabliceNaEkran(tablica);
}

static int WczytajZKlawiatury(string komunikat)
{
    Console.Write(komunikat);
    return int.Parse(Console.ReadLine());
}

static char[,] WypelnijTablice(int n, int m)
{
    char[,] tablica = new char[n, m];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            if (i == 0 || i == n - 1 || j == 0 || j == m - 1)
            {
                tablica[i, j] = '#';
            }
            else
            {
                tablica[i, j] = ' '; 
            }
        }
    }

    return tablica;
}

static void WyswietlTabliceNaEkran(char[,] tablica)
{
    int n = tablica.GetLength(0);
    int m = tablica.GetLength(1);

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write(tablica[i, j]);
        }
        Console.WriteLine();
    }
}
Main();


//zadanie 14 
static void SolveAnEquation()
{
    double a = 1;
    double b = -3;
    double c = 2;

    var solution = QuadraticSolution(a, b, c);
    Console.WriteLine("Solution:");
    foreach (var x in solution)
    {
        Console.WriteLine(x);
    }
}
static double[] QuadraticSolution(double a, double b, double c)
{
    double delta = b * b + 4 * a * c;

    if (delta > 0)
    {
        double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
        double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
        return new double[] { x1, x2 };
    }

    else if (delta == 0)
    {
        double x = -b / (2 * a);
        return new double[] { x };
    }
    else 
    {
        double realPart = -b / (2 * a);
        double imaginaryPart = Math.Sqrt(-delta) / (2 * a);
        return new double[] { realPart, imaginaryPart };
    }
}
SolveAnEquation();