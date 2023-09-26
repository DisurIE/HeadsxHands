using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadsxHands
{
    internal class Entity
    {
        private int _attack;
        private int _protection;
        private int _health;
        public (int Min, int Max) Damage { get; }

        public readonly int maxHealth = Constants.MaxHealth;
        private int _amountOfHealing = 4;

        public int Attack
        {
            get
            {
                return _attack;
            }

            set
            {
                if (value > 0 && value < 31)
                {
                    _attack = value;
                }
                else
                {
                    _attack = 1;
                }
            }
        }

        public int Protection
        {
            get
            {
                return _protection;
            }

            set
            {
                if (value > 0 && value < 31)
                {
                    try
                    {
                        _protection = value;
                    }
                    catch
                    {
                        _protection = 1;
                    }
                }
                else
                {
                    _protection = 1;
                }
            }
        }

        public int Health
        {
            get
            {
                return _health; 
            }

            set
            {
                _health = value;

                if (!IsAlive())
                {
                    _health = 0;
                }
            }
        }

        public Entity()
        {
            this.Attack = Constants.MinAttack;
            this.Protection = Constants.MinProtection;
            this.Health = Constants.StandartHealth;
            this.maxHealth = this._health;
            this.Damage = (1, 2);
        }

        public Entity(int attack, int protection, int health, (int Min, int Max) damage)
        {
            this.Attack = attack;
            this.Protection = protection;
            this._health = health;
            this.maxHealth = this._health;
            this.Damage = damage;
        }

        public virtual void getInformation()
        {
            Console.WriteLine("Существо: ");
            Console.WriteLine($"Атака: {this.Attack}");
            Console.WriteLine($"Защита: {this.Protection}");
            Console.WriteLine($"Здоровье: {this.Health}");
            Console.WriteLine($"Урон: {this.Damage}");
        }

        public bool IsAlive()
        {
            return Health > 0;
        }

        public bool AttackOpponent(Entity opponent)
        {
            if (!opponent.IsAlive()){
                Console.WriteLine("Умер");
                return false;
            }
            int attackModifier = Attack - opponent.Protection + 1;
            attackModifier = Math.Max(1, attackModifier);

            List<int> diceRolls = new List<int>();
            Random rand = new Random();

            for (int i = 0; i < attackModifier; i++)
            {
                diceRolls.Add(rand.Next(1, 7));
            }

            bool success = diceRolls.Contains(5) || diceRolls.Contains(6);

            if (success)
            {
                int damage = rand.Next(Damage.Min, Damage.Max + 1);
                opponent.TakeDamage(damage);
            }

            return success;
        }


        public void Heal()
        {
            if (_amountOfHealing > 0 && IsAlive())
            {
                this._amountOfHealing--;
                this.Health += (int)(this.maxHealth * 0.3);
                this.Health = Math.Min(this.Health, this.maxHealth);
            }
        }
        
        public void TakeDamage(int damage)
        {
            Health -= damage;
        }

    }
}
