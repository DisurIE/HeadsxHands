using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadsxHands
{
    internal class Player : Entity
    {
        public Player( int attack, int protection, int health, (int Min, int Max) damage)
        : base(attack, protection, health, damage)
        {
        }
    }
}
