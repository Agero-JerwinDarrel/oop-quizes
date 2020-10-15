using System;
using Animalinf;
using System.Threading;
namespace Quiz1oop
{
    class AnimalProgram
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();

            Console.Write("Give your animal a name: ");
            animal.Aname = Console.ReadLine();

            Console.WriteLine("What a cute name!");
            Thread.Sleep(2500);
            Console.WriteLine("Reminder, when choosing use the uppercase letters!");
            Console.WriteLine("Do you want " + animal.Aname + "to? ([E]at, [S]leep, [D]rink)");
            string a = Console.ReadLine();

            if (a == "E")
            {
                animal.eat();
            }
            else if (a == "S")
            {
                animal.sleep();
            }
            else if (a == "D")
            {
                animal.drink();
            }
        }
    }
}
