using System;
using System.Threading;
namespace Animalinf
{

    public class Animal
    {
        public string Aname { get; set; }
        public void name()
        {

            this.Aname = Console.ReadLine();

        }

        public void eat()
        {
            Console.WriteLine("Choose What to feed "+ Aname+ "[M]eat, [V]egetables, [F]ruits");
            string c = Console.ReadLine();
            Thread.Sleep(2500);

            if (c == "M")
            {
                Console.WriteLine("The diet you gave " +Aname+ " is Meat");
            }
            if (c == "V")

            {
                Console.WriteLine("The diet you gave " + Aname + "is Veggies");
            }
            if (c == "F")

            {
                Console.WriteLine("The diet you gave " + Aname + "is Fruits");
            }
            else 

            {
                Console.WriteLine("An Invalid option "+Aname+ " Starved to death!");
            }
        }
        public void sleep()
        {
            Console.WriteLine(Aname + " Will now sleep");
        }

        public void drink()
        {
            Console.WriteLine(Aname + " Drank water!");
        }
    }
}