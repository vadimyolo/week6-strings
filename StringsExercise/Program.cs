using System;

namespace StringsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloworld = "hello world!";       

            Console.WriteLine(helloworld[0]);


            int helloworldLength = helloworld.Length;
            Console.WriteLine($"Teie sõna on {helloworldLength} sümbolit pikk.");

            Console.WriteLine(helloworld[helloworldLength - 1]);


        }
    }
}
