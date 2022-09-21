using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            string imie = "Jan";
            string nazwisko = "Kowalski";

            Console.WriteLine("Witaj " + imie + " " + nazwisko + " " + "tutaj");
            Console.WriteLine("Witaj {0} {0} {0} tutaj", imie, nazwisko);
            Console.WriteLine($"Witaj {imie} {nazwisko} tutaj");
            //imie.length();

            Console.WriteLine("Predkosc to km\\h");
            Console.WriteLine(@"Predkosc to km\h");

            int liczba = 5;
            double liczba1 = 132.123;
            
            int liczebnik = 555;
            
 


            Person firstPerson = new Person();

            firstPerson.showInfo();


            Person secondPerson = firstPerson;

            secondPerson.showInfo();

            Person thirdPerson = new Person("Ala", "Kowalska", 70);

            thirdPerson.showInfo();

            thirdPerson.SetSurname("Nowak");
            thirdPerson.showInfo();

            string surname = thirdPerson.GetSurname();

            Console.WriteLine(surname);

            //thirdPerson.Age = 50;
            int d = thirdPerson.Age;


        }
    }
}
