using System;

namespace HeadsxHands // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            game.AddMonster("Гоблин 1", MonsterType.Goblin, 15, 10, 50, (4, 8));
            game.AddMonster("Гоблин 2", MonsterType.Goblin, 14, 9, 48, (3, 7));
            game.AddMonster("Дракон", MonsterType.Dragon, 30, 25, 100, (10, 20));
            game.AddMonster("Зомби 1", MonsterType.Zombie, 10, 5, 40, (2, 6));
            game.AddMonster("Зомби 2", MonsterType.Zombie, 11, 6, 42, (2, 7));

            game.Start();
        }
    }
}