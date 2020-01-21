using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            var favorite = 4;
            var guess = int.Parse(Console.ReadLine());
            if(guess < favorite)
            {
                Console.WriteLine("Too low");
            }
            else if( guess > favorite)
            {
                Console.WriteLine("Too high");
            }
            else
            {
                Console.WriteLine("Nevermind");
            }
        }
    }
}
