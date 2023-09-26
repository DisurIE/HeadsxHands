using System;

namespace HeadsxHands // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Entity man = new Entity(30, 5, 200, (1 ,40));
            Entity man2 = new Entity(5, 1, 100, (1, 6));
            int f = 0;
            int t = 0;
            int s;
            for (int i = 0; i < 10; i++)
            {
                s = man.AttackOpponent(man2) ? t++ : f++;
                Console.WriteLine(man2.maxHealth);
                Console.WriteLine(man2.Health);
            }
            Console.WriteLine(t);
            Console.WriteLine(f);
        }
    }
}