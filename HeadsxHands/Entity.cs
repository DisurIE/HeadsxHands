using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadsxHands
{
    internal class Entity
    {
        private int _damage;
        private int _protection;
        private int _health;

        public int Damage { get { return _damage;} }
        public int Protection { get { return _protection;} }
        public int Health { get { return _health;} }

        public Entity()
        {
            this._damage = 0;
            this._protection = 0;
            this._health = 0;
        }

        public Entity(int damage, int protection, int health)
        {
            this._damage = damage;
            this._protection = protection;
            this._health = health;
        }

    }
}
