using System;

// Zadanie 1
double x, y, z;

Console.Write("Podaj pierwsza liczbe: ");
x = Convert.ToDouble(Console.ReadLine());

Console.Write("Podaj drugą liczbe: ");
y = Convert.ToDouble(Console.ReadLine());

Console.Write("Podaj pierwsza liczbe: ");
z = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Średnia arytmetyczna tych liczb to: " + ((x+y+z) / 3));

// Zadanie 2
double P;

Console.Write("Podaj pole koła: ");
P = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Obwód tego koła to: " + 2 * Math.PI * Double.Sqrt(P / Math.PI));

// Zadanie 3
double w, h;

Console.Write("Podaj wzrost (m): ");
h = Convert.ToDouble(Console.ReadLine());

Console.Write("Podaj wagę (kg): ");
w = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Twoje BMI wynosi: " + w / Math.Pow(h, 2));

// Zadanie 4
int a, b, c, d, xx, yy;

Console.WriteLine("Podaj 4 liczby całkowite");

Console.Write("1 liczba: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("2 liczba: ");
b = Convert.ToInt32(Console.ReadLine());

Console.Write("3 liczba: ");
c = Convert.ToInt32(Console.ReadLine());

Console.Write("4 liczba: ");
d = Convert.ToInt32(Console.ReadLine());

if (b == 0 || d == 0)
{
    Console.WriteLine("Brak rozwiązań");
}
else
{
    xx = (a * d) + (c * b);
    yy = (b * d);
    Console.WriteLine("x = " + xx);
    Console.WriteLine("y = " + yy);
}

// Zadanie 5
double l1, l2;

Console.Write("Podaj 1 liczbe: ");
l1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Podaj 2 liczbe: ");
l2 = Convert.ToDouble(Console.ReadLine());

if (l1 > l2)
{
    Console.WriteLine(l1);
}
else
{
    Console.WriteLine(l2);
}

// Zadanie 6
double bok1, bok2, bok3;

Console.Write("Podaj długość 1 boku: ");
bok1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Podaj długość 2 boku: ");
bok2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Podaj długość 3 boku: ");
bok3 = Convert.ToDouble(Console.ReadLine());

if((bok1 + bok2 + bok3) / 3 == bok1)
{
    Console.WriteLine("Podane boki trójkąta mogą tworzyć trójkąt równoboczny");
}
else
{
    Console.WriteLine("Podane boki trójkąta NIE mogą tworzyć trójkąta równobocznego");

}

// Zadanie 7
int wx, wy, r2;

Console.WriteLine("Podaj współrzędne punktu P");

Console.Write("X = ");
wx = Convert.ToInt32(Console.ReadLine());

Console.Write("Y = ");
wy = Convert.ToInt32(Console.ReadLine());

Console.Write("Podaj długość promienia: ");
r2 = Convert.ToInt32(Console.ReadLine());

if (Math.Pow((wx - 0), 2) + Math.Pow((wy - 0), 2) <= Math.Pow(r2, 2))
{
    Console.WriteLine("Punkt P należy do okręgu");
}
else
{
    Console.WriteLine("Punkt P NIE należy do okręgu");
}

// Zadanie 8
double num1, num2, result = 0;

Console.Write("Podaj pierwszą liczbę: ");
num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Podaj drugą liczbę: ");
num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Wybierz działanie");
Console.WriteLine("1. Dodawanie");
Console.WriteLine("2. Odejmowanie");
Console.WriteLine("3. Mnożenie");
Console.WriteLine("4. Dzielenie");
start:
var option = Console.ReadKey().KeyChar;
switch (option)
{
    case '1':
        Console.WriteLine("Wynik: " + (num1 + num2)); 
        break;
    case '2': 
        Console.WriteLine("Wynik: " + (num1 - num2)); 
        break;
    case '3': 
        Console.WriteLine("Wynik: " + (num1 * num2)); 
        break;
    case '4': 
        if (num2 != 0) 
        { 
            Console.WriteLine("Wynik: " + (num1 / num2)); 
            break;
        }
        else 
        { 
            Console.WriteLine("Wynik: " + num1 + "/0");
        } 
        break;
        default: 
            goto start;
}

// Zadanie 9
int anum, bnum, cnum;

void Swap(ref int a, ref int b, ref int c)
{
    a = a + b + c;
    b = a - (b + c);
    c = a - (b + c);
    a = a - (b + c);
}

Console.Write("Podaj pierwszą liczbę: ");
anum = Convert.ToInt32(Console.ReadLine());
Console.Write("Podaj drugą liczbę: ");
bnum = Convert.ToInt32(Console.ReadLine());
Console.Write("Podaj trzecią liczbę: ");
cnum = Convert.ToInt32(Console.ReadLine());

Swap(ref anum, ref bnum, ref cnum);

Console.WriteLine("Po zamianie");
Console.WriteLine("Pierwsza liczba: " + anum);
Console.WriteLine("Druga liczba: " + bnum);
Console.WriteLine("Trzecia liczba: " + cnum);

// Zadanie 10 
UInt64 n;

Console.Write("Podaj liczbe naturalną: ");
n = Convert.ToUInt64(Console.ReadLine());

n = n % 10;
Console.WriteLine("Ostatnia cyfra tej liczby to: " + n);

// Zadanie 11

decimal t, u = 0; // t = x, u = y

Console.Write("Podaj x: ");
t = Convert.ToDecimal(Console.ReadLine());
if (t < 2)
{
    u = t - 1;

    if (t <= 1 & t >= -1)
    {
        u = 0;
    }

    if (t < -1 & t > -2)
    {
        u = t + 1;
    }

    if (t <= -2)
    {
        u = -1;
    }
}
else if(t >= 2)
{
    u = 1;
}

Console.WriteLine("Dla x=" + t + " y=" + u);




