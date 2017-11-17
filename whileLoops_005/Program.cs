using System;

namespace whileLoops_005
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How old are you? ");
            int age = int.Parse(Console.ReadLine());
            // do while loop is guaranteed to run at
            // least once
            do
            {
                Console.Write(("Happy Birthday "));
                // -- = reduce by one
                age--;
            } while (age > 0);
            Console.WriteLine(("\nTaDa!"));
        }
    }
}
