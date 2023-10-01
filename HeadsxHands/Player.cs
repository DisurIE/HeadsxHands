using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadsxHands
{
    internal class Player : Entity
    {
        public string Name { get; }

        public Player(string name, int attack, int protection, int health, (int Min, int Max) damage)
        : base(attack, protection, health, damage)
        {
            Name = name;
        }

        public override void getInformation()
        {
            Console.WriteLine($"{this.Name}: ");
            Console.WriteLine($"Атака: {this.Attack}");
            Console.WriteLine($"Защита: {this.Protection}");
            Console.WriteLine($"Здоровье: {this.Health}");
            Console.WriteLine($"Урон: {this.Damage}");
        }

    }
}
