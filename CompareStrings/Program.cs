using System;

namespace CompareStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta oma eesnimi.");
            string firstName = Console.ReadLine();

            Console.WriteLine("sisesta oma perekonnanimi.");
            string lastname = Console.ReadLine();

            if(firstName.Length > lastname.Length)
            {
                Console.WriteLine("Eesnimi on pikem kui perekonnanimi.");
            }
            else if(firstName.Length < lastname.Length)
            {
                Console.WriteLine("Perekonnanimi on pikem kui eesnimi.");
            }
            else
            {
                Console.WriteLine("sama pikad.");
            }
        }
    }
}
