using Battle_System.Classes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_System.Classes.Entities
{
    internal class Enemy : Entity
    {
        public Enemy(string name) : base(name)
        {

        }
    }
    internal class Spiders : Enemy
    {
        public Spiders() : base("Spiders")
        {
            strength = 1;
            EquipItem(new Weapon("wand", "a long wand", 4));
        }
    }

    internal class Goblin : Enemy
    {
        public Goblin() : base("Goblin")
        {
            strength = 3;
            EquipItem(new Weapon("wand", "a long wand", 4));
        }
    }

    internal class Skeleton : Enemy
    {
        public Skeleton() : base("Skeleton")
        {
            strength = 4;
            EquipItem(new Weapon("wand", "a long wand", 4));
        }
    }

    internal class Witches : Enemy
    {
        public Witches() : base("Witches")
        {
            strength = 6;
            EquipItem(new Weapon("wand", "a long wand", 4));
        }
    }

    internal class Giant : Enemy
    {
        public Giant() : base("Giant")
        {
            strength = 11;
            EquipItem(new Weapon("wand", "a long wand", 4));
        }
    }

}
