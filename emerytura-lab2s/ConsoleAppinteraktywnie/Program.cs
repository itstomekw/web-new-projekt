﻿using System;

namespace ConsoleAppinteraktywnie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Podaj swoje imię:  ");
            string imie;
            imie = Console.ReadLine();

            Console.Write("Podaj swoje nazwisko:  ");
            string nazwisko = Console.ReadLine();

            Console.WriteLine("Witaj, " + imie + " " + nazwisko + "!");
            string napis = string.Format("witaj, {0} {1}!", imie, nazwisko);
            Console.WriteLine( napis );

            Console.WriteLine("Witaj, {0} {1}!", imie, nazwisko");

                Console.WriteLine($"Wtaj, {imie} {nazwisko}!");

        }
    }
}
