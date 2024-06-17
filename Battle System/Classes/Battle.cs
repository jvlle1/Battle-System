using Battle_System.Classes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_System.Classes
{
    internal class Battle
    {
        private Player player;
        private Enemy enemy;

        private bool over;

        public Battle(Player player, Enemy enemy) 
        {
            this.player = player;
            this.enemy = enemy;
            over = false;
        }
        public void Loop()
        {
            while (!over)
            {
                int PlayerAttack = player.Attack();
                enemy.Damage(PlayerAttack);
                Console.WriteLine($"you attack the {enemy.GetName()} " +
                    $"with your {player.GetWeaponName()} " +
                    $"and deal {PlayerAttack} damage");
                Console.WriteLine($"{enemy.GetName()} has {Math.Max(enemy.GetHp(), 0)} health");

                Console.ReadLine();

                if (enemy.GetHp() == 0)
                {
                    Console.WriteLine($"Congrats!, You have defeated the {enemy.GetName()}");
                    Console.ReadLine();
                    over = true;
                    break;
                }

                int enemyAttack = enemy.Attack();
                player.Damage(enemyAttack);
                Console.WriteLine($"the {enemy.GetName()} attacks you " +
                    $"with a {enemy.GetWeaponName()} " +
                    $"and deals {enemyAttack} damage");
                Console.WriteLine($"you have {player.GetHp()} health");
           
                Console.ReadLine();

                
                if (player.GetHp() == 0)
                {
                    Console.WriteLine($"Game over, The {enemy.GetName()} has defeated you");
                    break;
                }
            }

        }
    }
}
