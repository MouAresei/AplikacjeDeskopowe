using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismApp
{
    class Dog : Animal 
    {
        protected string name;
        protected byte age;
       
        public Dog()
        {
            name = "bjorn";
            age = 10;
        }


        Dog(string name, byte age) : base(name, age)

        {
           
          
        }

        public Dog(Dog dogToCopy) : base(dogToCopy)
        {
         
           
       
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
