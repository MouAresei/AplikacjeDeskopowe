using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismApp
{
    class Dog
    {
        private string name;
        private byte age;
        private byte atack_damage;
        private byte hp;

        public Dog()
        {
            name = "bjorn";
            age = 10;
        }


        Dog(string name, byte age, byte atack_damage, byte hp)
        {
            this.name = name;
            this.age = age;
            this.atack_damage = atack_damage;
            this.hp = hp;
        }

        public Dog(Dog dogToCopy)
        {
            name = dogToCopy.name;
            age = dogToCopy.age;
            atack_damage = dogToCopy.atack_damage;
            hp = dogToCopy.hp
           
        }

        public void ShowInfo()
        {
            Console.WriteLine("#######################################");
            Console.WriteLine("######################################");
            Console.WriteLine("pies o imieniu" + name + "ma lat" age);
            Console.WriteLine("#######################################");
            Console.WriteLine("#######################################");
        }

        public void bark()

        {
            Console.WriteLine("pies o imieniu" + name + "szczeka")
        }

        public void ChasePostman()
        {
            Console.WriteLine("Pies o imieniu" + name + "goni listonosza")
        }

    }









}
