using Battle_System.Classes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_System.Classes.Entities
{
    public class Player : Entity
    {
        protected string ClassName;
        public Player(string name) : base(name)
        {
            GiveItem(new Item("food", "some food"));
            GiveItem(new Item("torch", "a torch"));
            GiveItem(new Item("map", "a map"));
            ClassName = "None";
        }
        internal void GiveItem(Item item)
        {
            
        }
        public string GetClassName()
        {
            return ClassName;
        }
    }
    public class Fighter : Player
    {
        public Fighter(string name) : base(name) 
        {
            strength = 5;
            ClassName = "Fighter";
            EquipItem(new Weapon("sword", "a basic sword", 1));
        }
    }

    public class Magician : Player
    {
        public Magician(string name) : base(name)
        {
            strength = 10;
            ClassName = "Magician";
            EquipItem(new Weapon("wand", "a long wand", 4));
        }
        public override int Attack()
        {
            Console.WriteLine("Yeah!");
            return 1000;
        }
    }

    public class  Knight : Player
    {
        public Knight(string name) : base(name)
        {
            strength = 12;
            ClassName = "Knight";
            EquipItem(new Weapon("axe", "deadly axe", 6));
        }
    }


}
