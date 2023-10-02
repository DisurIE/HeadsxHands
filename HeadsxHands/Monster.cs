

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

        public Monster(MonsterType type, int attack, int protection, int health, (int Min, int Max) damage)
        : base(attack, protection, health, damage)
        {
            Type = type;
        }
    }
}
