using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadsxHands
{

    enum MonsterType
    {
        Goblin,
        Dragon,
        Zombie,
    }

    class Monster : Entity
    {
        public MonsterType Type { get; }


    }
}
