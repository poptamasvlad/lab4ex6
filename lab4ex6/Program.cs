using System;

namespace lab4ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Scrieti o functie recursiva care va calcula al n-lea element din sirul lui
            Fibonacci, n fiind citit de la tastatura, apelati-o si afisati-I rezultatul.*/

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Fibonacci(n));
            
        }

        static int Fibonacci(int n)
        {
            int numar = 0;
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            numar = Fibonacci(n - 1) + Fibonacci(n - 2);
            return numar;
        }
    }
}
