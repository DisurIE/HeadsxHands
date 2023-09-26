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

        private readonly int _maxHealth = Constants.MaxHealth;
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
                    try
                    {
                        _attack = value;
                    }
                    catch
                    {
                        _attack = 1;
                    }
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
                if (IsAlive())
                {
                    _health = value;
                }
                else
                {
                    _health = 0;
                }
            }
        }

        public Entity()
        {
            this.Attack = 1;
            this.Protection = 1;
            this._health = 1;
            this._maxHealth = this._health;
            this.Damage = (1, 2);
        }

        public Entity(int attack, int protection, int health, (int Min, int Max) damageRange)
        {
            this.Attack = attack;
            this.Protection = protection;
            this._health = health;
            this._maxHealth = this._health;
            this.Damage = damageRange;
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

        public void AttackEnemy(Entity enemy)
        {

        }


        public void Heal()
        {
            if (_amountOfHealing > 0)
            {
                this._amountOfHealing--;
                this.Health += (int)(this._maxHealth * 0.3);
                this.Health = Math.Min(this.Health, this._maxHealth);
            }
        }
        
        public void TakeDamage(int damage)
        {
            Health -= damage;
        }

    }
}
