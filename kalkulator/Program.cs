using System;
using System.ComponentModel.Design;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    static void Main(string[] args)
    {
        string wybor;
        do
        {
            Console.WriteLine("\n== Kalkulator ==");

            double liczbaA = ReadDouble("Podaj pierwszą liczbę:");
            double liczbaB = ReadDouble("Podaj drugą liczbę:");
            char znak = ReadOperator("Podaj znak działania (+, -, *, /):");


            double wynik = 0;

            bool DzieleniePrzezZero = Obliczenia(liczbaA, liczbaB, znak, out wynik);
            if (DzieleniePrzezZero)
            {
                Console.WriteLine("Wynik: " + wynik);
            }
            else
            {
                Console.WriteLine("Nie można dzielić przez zero");
            }
            Console.WriteLine("\nCzy chcesz liczyć dalej? (t/n)");
            wybor = Console.ReadLine();
        } while (wybor == "t");
    }

    static char ReadOperator(string prompt)
    {
        while (true)
        {
            Console.WriteLine(prompt);
            string result = Console.ReadLine() ?? "";
            if (result == "+" || result == "-" || result == "*" || result == "/")
            return char.Parse(result);
        
            else
            {
                Console.WriteLine("Zły znak");

            }
        }
    }
static double ReadDouble(string prompt)
    {
        double result;
        Console.WriteLine(prompt);
        while (!double.TryParse(Console.ReadLine(), out result))
        {
            Console.WriteLine("Podaj poprawną liczbę:");
        }
        return result;
    }
    static bool Obliczenia(double liczbaA, double liczbaB, char znak, out double wynik)
    {
        wynik = 0;
        switch (znak)
        {
            case '+':
                wynik = liczbaA + liczbaB;
                return true;
            case '-':
                wynik = liczbaA - liczbaB;
                return true;
            case '*':
                wynik = liczbaA * liczbaB;
                return true;
            case '/':
                if (liczbaB != 0)
                {
                    wynik = liczbaA / liczbaB;
                    return true;
                }
                return false;
            default:
                return false;
        }
    }
}