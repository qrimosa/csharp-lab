/* zadanie 1 */
using System.Threading.Channels;

Console.WriteLine("Zmienne i typy danych");
byte byteVariable = 50;
int integralVariable = 300;
long longVariable = 100000000;
char charVariable1 = (char)87;
char charVariable2 = 'a';
double doubleVariable = 50.0005;
float floatVariable = 50e10F;
string stringVariable = "How you doing?";
// tutaj wpisz rozwiązanie
Console.WriteLine(byteVariable);
Console.WriteLine(integralVariable);
Console.WriteLine(longVariable);
Console.WriteLine(charVariable1);
Console.WriteLine(charVariable2);
Console.WriteLine(doubleVariable);
Console.WriteLine(floatVariable);
Console.WriteLine(stringVariable);
/* koniec zadania 1 */


/* zadanie 2 */
int num = 2147483647;
long bigNum = 88888888888;
string stringNum = "1024";

long longNum = num;
Console.WriteLine(longNum);

int integerValue = (int)bigNum;
Console.WriteLine(bigNum);
Console.WriteLine(integerValue);

int intNum2 = int.Parse(stringNum);
Console.WriteLine(intNum2);
//Console.WriteLine(longNum, intNum, intNum2);
// zadeklaruj zmienną typu long i przypisz do niej zmienną num
// zadeklaruj zmienną typu int i przypisz do niej zmienną bigNum
// zadeklaruj zmienną typu int i przypisz do niej zmienną stringNum (zastosuj Parse)
// zbadaj zachowanie programu

/* koniec zadania 2 */


/* zadanie 3 */
int a = 18;
int b = 6;
decimal price = 10.56m;
double doubleVal = 10.56;
double radius = 5.0;
double time = 1234.45;
// zadeklaruj zmienną c, do której przypisz wynik dodawania a i b 
int c = a + b;
// zadeklaruj zmienną d, do której przypisz wynik odejmowania a i b 
int d = a - b;
// zadeklaruj zmienną e, do której przypisz wynik mnożenia a i b 
int e = a * b;
// zadeklaruj zmienną f, do której przypisz wynik dzielenia a i b 
int f = a / b;
// zadeklaruj zmienną g, do której przypisz wynik reszty z dzielenia a i b 
int g = a % b;
// wypisz na ekran c,d,e,f,g
Console.WriteLine(c);
Console.WriteLine(d);
Console.WriteLine(e);
Console.WriteLine(f);
Console.WriteLine(g);
// wypisz na ekran wynik zmiennej price pomnożonej przez samą siebie
Console.WriteLine(price * price);
// wypisz na ekran wynik zmiennej doubleVal pomnożonej przez samą siebie
Console.WriteLine(doubleVal * doubleVal);
// zastanów się skąd się bieże różnica
// wypisz na ekran wynik pola koła o promieniu równym radius
Console.WriteLine(Math.PI * radius * radius);
// W zmiennej time znajduje się czas w minutach. Oblicz wartości zmiennych hours, minutes i seconds na postawie zmiennej time
var hours = time / 60;
Console.WriteLine(hours);
var minutes = (int)time;
Console.WriteLine(minutes);
var seconds = (int)time * 60;
Console.WriteLine(seconds);
/* koniec zadania 3 */


/* zadanie 4 */
int toIncrement = 3;
int toDivide = 5;
// wstaw do zmiennej toIncrement jej obecną wartość powiększoną o jeden (nie używając żadnej cyfry)
toIncrement++;
// wstaw do zmiennej toDivide jej obecną wartość podzieloną o nią samą (nie używając żadnej cyfry)
toDivide /= toDivide;
/* koniec zadania 4 */


/* zadanie 5 */
double degree = 45;
double sinValue;
// do zmiennej sinValue przypisz wartość funkcji sinus dla zmiennej degree wyrażonej w stopniach
sinValue = Math.Sin(degree);
/* koniec zadania 5 */


/* zadanie 6 */
int year = 2024;
int month = 5;
int day = 3;
int hour = 23;
int minute = 30;
int second = 10; 
// stwórz zmienną typu DateTime jako wartość złożoną z powyższych składowych
var date1 = new DateTime(year, month, day, hour, minute, second);
// następnie dodaj do niej 3 miesiące, odejmij 1 godzinę
date1 = date1.AddMonths(3);
date1 = date1.AddHours(-1);
// wypisz na ekran nazwę dnia tygodnia jaki przypada tego dnia
Console.WriteLine(date1.DayOfWeek);
/* koniec zadania 6 */


/* zadanie 7 */
string firstPart = "This is";
string secondPart = "a string";
string thirdPart = "with capital letters.";
// stwórz nową zmienną typu string jako złączenie powyższych.
string allTogether = firstPart + " " + secondPart + " " +thirdPart;
// pamiętaj o brakujących odstępach
// wypisz na ekran tekst nowej zmiennej DRUKOWANYMI LITERAMI
Console.WriteLine(allTogether.ToUpper());
// oraz liczbę przedstawiającą długość tego ciągu znaków
Console.WriteLine(allTogether.Length);

/* koniec zadania 7 */


/* zadanie 8 */
double lengthA = 5;
double lengthB = 1;
double lengthC = 3;
// zadeklaruj zmienną typu bool, przypisz do niej wartość mówiącą czy z powyższych 3 odcinków da się zbudować trójkąt
bool isTriangle = (lengthB + lengthC > lengthA);
// jeśli tak, to sprawdź czy jest to trójkąt prostokątny (kolejna zmienna bool)
bool isRightTriangle = (lengthA * lengthA == lengthB * lengthB + lengthC * lengthC);
/* koniec zadania 8 */


/* zadanie 9 */
string conditionalString = "To be or not to be?";
// jeśli długość ciągu znaków jest większa niż 10 to wyświetl na ekran ten tekst
if (conditionalString.Length > 10)
{
    Console.WriteLine(conditionalString);
}
else
{
    Console.WriteLine("Lenght of the string is less than 10!");
}

/* koniec zadania 9 */


/* zadanie 10 */
int temperature = 22;
// jeśli temperatura jest większa niż 20`C wyświetl "ciepło", w przeciwnym wypadku "zimno"
if (temperature > 20)
{
    Console.WriteLine("ciepło");
}
else
{
    Console.WriteLine("zimno");
}
/* koniec zadania 10 */

/* zadanie 11 */
var result = (temperature > 20) ? "ciepło" : "zimno";
Console.WriteLine(result);
/* koniec zadania 11 */

/* zadanie 12 */
int code = 4;
int quantity = 11;
decimal productPrice = 3.5m;
decimal sellPrice;

if (code < 10)
{
    sellPrice = productPrice;
}
else if (code >= 10 && code <= 15)
{
    sellPrice = productPrice * 0.95m; 
}
else 
{
    if (quantity <= 10)
    {
        sellPrice = productPrice * 1.05m; 
    }
    else if (quantity >= 11 && quantity <= 20)
    {
        sellPrice = productPrice; 
    }
    else if (quantity < 100)
    {
        int discountPercent = (quantity / 10) - 2; 
        discountPercent = Math.Max(discountPercent, 0); 
        sellPrice = productPrice * (1 - (discountPercent * 0.01m)); 
    }
    else 
    {
        sellPrice = productPrice * 0.90m; 
    }
}

Console.WriteLine($"Price: {sellPrice}");
/* koniec zadania 12 */


/* zadanie 13 */
char hexNum = 'E';

switch (hexNum)
{
    case '0':
        Console.WriteLine($"Decimal number: 0");
        break;
    case '1':
        Console.WriteLine($"Decimal number: 1");
        break;
    case '2':
        Console.WriteLine($"Decimal number: 2");
        break;
    case '3':
        Console.WriteLine($"Decimal number: 3");
        break;
    case '4':
        Console.WriteLine($"Decimal number: 4");
        break;
    case '5':
        Console.WriteLine($"Decimal number: 5");
        break;
    case '6':
        Console.WriteLine($"Decimal number: 6");
        break;
    case '7':
        Console.WriteLine($"Decimal number: 7");
        break;
    case '8':
        Console.WriteLine($"Decimal number: 8");
        break;
    case '9':
        Console.WriteLine($"Decimal number: 9");
        break;
    case 'A':
    case 'a':
        Console.WriteLine($"Decimal number: 10");
        break;
    case 'B':
    case 'b':
        Console.WriteLine($"Decimal number: 11");
        break;
    case 'C':
    case 'c':
        Console.WriteLine($"Decimal number: 12");
        break;
    case 'D':
    case 'd':
        Console.WriteLine($"Decimal number: 13");
        break;
    case 'E':
    case 'e':
        Console.WriteLine($"Decimal number: 14");
        break;
    case 'F':
    case 'f':
        Console.WriteLine($"Decimal number: 15");
        break;
    default:
        Console.WriteLine($"Not a valid hexadecimal number!");
        break;
}

/* koniec zadania 13 */