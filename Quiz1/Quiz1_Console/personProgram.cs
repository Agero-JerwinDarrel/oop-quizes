using System;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using people;
using System.Threading;
namespace peopleinfo
{
    class personProgram
    {
        static void Main(string[] args)
        {
            Person Person= new Person();

            Console.WriteLine("Please enter your last name ");
            Person.lname = Console.ReadLine();

            Console.WriteLine("Enter your First then Suffix name ");
            Person.fname = Console.ReadLine();
            Person.sname = Console.ReadLine();

            Console.WriteLine("Enter your Middle name ");
            Person.mname = Console.ReadLine();
            Console.WriteLine("Thank You!");
            Thread.Sleep(500);
            Console.WriteLine("Please Wait...");
            Thread.Sleep(2000);

            Console.Clear();
            Console.WriteLine("Hello! Mr./Mrs. " +Person.lname +" "+ Person.fname + " " + Person.sname +" "+ Person.mname);

            Console.WriteLine("Please enter Your Birth Month ");
            Person.month = Console.ReadLine();

            Console.WriteLine("Enter Your date of birth ");
            Person.day = Console.ReadLine();
           

            Console.WriteLine("Enter The year of your birth ");
            Person.year = Console.ReadLine();
            Console.WriteLine("Please Wait...");
            Thread.Sleep(2500);

            Console.Clear();
            Thread.Sleep(2500);
            Console.WriteLine(" Thank you for waitng!");

            Console.WriteLine("Your Name: " + Person.fname + " " + Person.sname + " " + Person.mname + " " +
                Person.lname);
            Console.WriteLine("Your Birthdate " + Person.month + " " + Person.day + ", " + Person.year);


        }

    }
}
