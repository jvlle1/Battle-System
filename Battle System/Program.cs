using Battle_System.Classes;
using Battle_System.Classes.Entities;
using Battle_System.Classes.Items;

namespace Battle_System
{
    internal class Program
    {
        static Player player;
        static void Main(string[] args)
        {
            Player player = PlayerSetup();

            Console.WriteLine($"Welcome, {player.GetName()}!");
            Console.WriteLine($"You are a {player.GetClassName()}");
            Console.WriteLine($"You have a {player.GetWeaponName()}, it is {player.GetWeaponDescription()}");

            List<Enemy> enemyList = new List<Enemy>
            {
                new Spiders(),
                new Goblin(),
                new Skeleton(),
                new Witches(),
                new Giant(),
            };
        
            Console.WriteLine("Press enter to start battle...");
            Console.ReadLine();

            foreach (var enemy in enemyList)
            {
                Battle thisBattle = new Battle(player, enemy);
                thisBattle.Loop();

                if (player.GetHp() <= 0)
                {
                    break; 
                }
            }
        }

        static Player PlayerSetup()
        {
            string playerName = PresenceCheck("Enter your name");

            string playerClassChoice = OptionCheck("Select your class from the list below:\n" +
                "1: Fighter\n" +
                "2: Magician\n",
                new string[] { "1", "2"});

            if (playerClassChoice == "1")
            {
                player = new Fighter(playerName);
            }
            else if (playerClassChoice == "2")
            {
                player = new Magician(playerName);
            }

            return player;
        }

        static string PresenceCheck(string message)
        {
            string userInput = "";
            while (userInput.Length == 0)
            {
                Console.WriteLine(message);
                userInput = Console.ReadLine();
            }
            return userInput;
        }
        static string OptionCheck(string message, string[] options)
        {
            string userInput = "";
            while (!options.Contains(userInput))
            {
                userInput = PresenceCheck(message);
            }
            return userInput;
        }
    }
}