using System;

namespace HeadsxHands // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Entity man = new Entity(30, 5, 200, (200 ,400));
            Entity man2 = new Entity(5, 1, 1000, (1, 6));

            int f = 0;
            int t = 0;
            int s;

            for (int i = 1; i < 10; i++)
            {
                s = man.AttackOpponent(man2) ? t++ : f++;
                Console.WriteLine(man2.maxHealth);
                Console.WriteLine(man2.Health);
                if (i % 2 == 0)
                {
                    man2.Heal();
                }
                Console.WriteLine(man2.Health);
            }

            Console.WriteLine(t);
            Console.WriteLine(f);
        }
    }
}