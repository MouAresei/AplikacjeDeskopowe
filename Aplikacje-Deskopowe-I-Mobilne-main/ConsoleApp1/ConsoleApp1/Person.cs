using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {

        private string name;
        public string Name
        {
            set
            {
                name = value;
            }

            get
            {
                return name;
            }
        }
        
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
        }




        private string surname;
        public string Surname
        {
            set
            {

                if (value != "")
                    surname = value;

            }

            get
            {

                return surname;
            }

        }








        public Person()
        {
            name = "Adam";
            surname = "Kowalski";
            age = 79;
        }

        public Person(string n, string s, int a)
        {
            name = n;
            surname = s;
            age = a;
        }

        public void showInfo()
        {
            Console.WriteLine("***************************");
            Console.WriteLine($"Imie:  {name}");
            Console.WriteLine($"Nazwisko: {surname}");
            Console.WriteLine($"Wiek: {age}");
            Console.WriteLine("****************************");

        }

        public void SetSurname(string new_surname)
        {
            if(new_surname != "")
            {
                surname = new_surname;
            }
            
        }

        public string GetSurname()
        {
            return surname;
        }

    };



    public void Test3 ()
    {
        PersonStruct ps = new PersonStruct();
            ps."Adam";
        Console.WriteLine("Pole name w Test3" + ps.name);
        GetPresonStruct(ps);
        Console.WriteLine("Pole name w Tekst3" + ps.name);
    }

    private void GetPersonStruct(PersonStruct ps)
        Console.WriteLine("Pole name )
















}
