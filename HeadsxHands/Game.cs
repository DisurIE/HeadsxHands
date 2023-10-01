using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HeadsxHands
{
    internal class Game
    {
        private Player _player = null;
        private List<Monster> _monsters = new List<Monster>();

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("Выберите действие: ");
                Console.WriteLine("1. Создать Игрока");
                Console.WriteLine("2. Создать Монстра");
                Console.WriteLine("3. Сражение");
                Console.WriteLine("4. Выход");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CreatePlayer();
                        break;
                    case "2":
                        CreateMonster();
                        break;
                    case "3":
                        Battle();
                        break;
                    case "4":
                        Console.WriteLine("Спасибо за игру!");
                        return;
                    default:
                        Console.WriteLine("Некорректный выбор. Попробуйте снова.");
                        break;
                }
            }
        }

        public void CreateMonster()
        {
        }

        public void CreatePlayer()
        {
            Console.WriteLine("Введите имя игрока:");
            string name = NameIsLetters();

            Console.WriteLine("Введите атаку игрока (1-30):");
            int attack = GetIntInput(1, 30);

            Console.WriteLine("Введите защиту игрока (1-30):");
            int defense = GetIntInput(1, 30);

            Console.WriteLine("Введите здоровье игрока (0-N):");
            int health = GetIntInput(0, int.MaxValue);

            Console.WriteLine("Введите минимальный урон игрока:");
            int minDamage = GetIntInput(1, int.MaxValue);

            Console.WriteLine("Введите максимальный урон игрока:");
            int maxDamage = GetIntInput(minDamage, int.MaxValue);

            _player = new Player(name, attack, defense, health, (minDamage, maxDamage));
            Console.WriteLine($"{name} успешно создан!");
            _player.getInformation();
        }

        public void Battle()
        {

        }
        public string NameIsLetters()
        {
            string name;

            while (true)
            {
                if (Regex.Match(name = Console.ReadLine(), @"[A-z,a-z]").Success)
                {
                    return name;
                }
                else
                {
                    Console.WriteLine($"Некорректный ввод. Попробуйте снова. ");
                }
            }
        }

        private int GetIntInput(int min, int max)
        {
            int value;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out value) && value >= min && value <= max)
                {
                    return value;
                }
                else
                {
                    Console.WriteLine($"Некорректный ввод. Попробуйте снова. " +
                                      $"Число должно быть в диапазоне ({min}, {max})");
                }
            }
        }
    }



}
