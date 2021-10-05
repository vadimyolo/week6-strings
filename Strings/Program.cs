using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun, sisesta oma eesnimi.");
            string firstName = Console.ReadLine();

            Console.WriteLine(firstName[0]);


            int firstNameLength = firstName.Length;
            Console.WriteLine($"Teie nimi on {firstNameLength} sümbolit pikk.");

            Console.WriteLine(firstName[firstNameLength-1]);
        }
    }
}
