using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Oto mój kalkulkator");

        double liczbaa;
        double liczbab;
        string znak;
        bool test1, test2;

        Console.WriteLine("Podaj pierwszą liczbę");
        test1 = double.TryParse(Console.ReadLine(), out liczbaa);
        while (!test1)
        {
            Console.WriteLine("Podaj poprawną pierwszą liczbę");
            test1 = double.TryParse(Console.ReadLine(), out liczbaa);
        }

        Console.WriteLine("Podaj drugą liczbę");
        test2 = double.TryParse(Console.ReadLine(), out liczbab);
        while (!test2)
        {
            Console.WriteLine("Podaj poprawną drugą liczbę");
            test2 = double.TryParse(Console.ReadLine(), out liczbab);
        }

        Console.WriteLine("Podaj znak działania (+, -, *, /)");
        znak = Console.ReadLine();

        while (znak != "+" && znak != "-" && znak != "*" && znak != "/")
        {
            Console.WriteLine("Podaj prawidłowy znak działania (+, -, *, /)");
            znak = Console.ReadLine();
        }

        Obliczenia(liczbaa, liczbab, znak);
    }
    private static void Obliczenia(double liczbaa, double liczbab, string znak) {
        switch (znak)
        {
            case "+":
                    Console.WriteLine("Wynik: " + (liczbaa + liczbab));
                    break;
            case "-":
                    Console.WriteLine("Wynik: " + (liczbaa - liczbab));
                    break;
            case "*":
                    Console.WriteLine("Wynik: " + (liczbaa * liczbab));
                    break;
            case "/":
                    if (liczbab != 0)
                        Console.WriteLine("Wynik: " + (liczbaa / liczbab));
                    else
                        Console.WriteLine("Nie można dzielić przez zero");
                    break;
        } 
    }
}

//if (!test1 || !test2) S
//{
//    Console.Write("Obie muszą byc liczbami");
//}
//else
//{
//    Console.WriteLine("Prosze podaj znak");
//    znak = Console.ReadLine();

//    if (znak == "+")
//    {
//        Console.WriteLine("Oto wynik działania: " + (liczbaa + liczbab));
//    }

//    if (znak == "-")
//    {
//        Console.WriteLine("Oto wynik działania: " + (liczbaa - liczbab));
//    }

//    if (znak == "/" && liczbaa != 0 && liczbab != 0)
//    {
//        Console.WriteLine("Oto wynik działania: " + (liczbaa / liczbab));
//    }
//    else
//    {
//        Console.WriteLine("liczby nie mogą wynosić zero");
//    }

//    if (znak == "*")
//    {
//        Console.WriteLine("Oto wynik działania: " + (liczbaa * liczbab));
//    }

//}


