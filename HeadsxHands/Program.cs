using System;

namespace HeadsxHands // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Entity man = new Entity(31, 1, 5, (1 ,6));
            for(int i = 0; i < 5; i++)
            {
                man.TakeDamage(1);
                Console.WriteLine(man.IsAlive());
                Console.WriteLine(man.Health);
            }
        }
    }
}