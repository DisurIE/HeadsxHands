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
        private int _damage;
        private int _maxHealth;

        private int _amountOfHealing = 4;
        private bool _isDead = false;
        public int Damage { get { return _damage; } }

        public bool IsDead
        {
            get
            {
                return _isDead;
            }
        }
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
                if (value <= 0)
                {
                    Died();
                    _health = value;
                }
                else
                {
                    _health = value;
                }
            }
        }

        public Entity()
        {
            this.Attack = 0;
            this.Protection = 1;
            this._health = 1;
            this._maxHealth = this._health;
            this._damage = 1;
        }

        public Entity(int attack, int protection, int health, int damage)
        {
            this.Attack = attack;
            this.Protection = protection;
            this._health = health;
            this._maxHealth = this._health;
            this._damage = damage;
        }

        public void Died()
        {
            this._isDead = true;
        }

        public void Heal()
        {
            this.Health = (int)(this._maxHealth * 0.3);
        }
    }
}
