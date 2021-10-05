using System;

namespace StringsAndForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta oma eesnimi:");
            string firstName = Console.ReadLine();

            for (int i = 0; i < firstName.Length; i++) 
            {
                Console.WriteLine(firstName[i]);
            }

            
        }
    }
}
