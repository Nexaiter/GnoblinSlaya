using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading;

namespace SenshiNoTabi
{
    public static class Game
    {
        public static void Fight(Player player, Monster enemy, Weapon playerWeapon, Weapon enemyWeapon, Armor playerArmor, Armor enemyArmor)
        {
            int damage;
            while (player.Health > 0 && enemy.Health > 0)
            {
                if (player.Initiative(playerWeapon, playerArmor) >= enemy.Initiative(enemyWeapon, enemyArmor))
                {
                    damage = player.BasicAttack(enemy, enemyArmor, playerWeapon, enemy.LevelDifference(player.CharacterLevel));
                    Console.WriteLine($"{player.Name} has dealt {damage} damage.");
                    enemy.Health -= damage;
                    Console.WriteLine($"{enemy.Name} is left with {enemy.Health} health.");
                    damage = enemy.BasicAttack(player, playerArmor, enemyWeapon, player.LevelDifference(enemy.CharacterLevel));
                    Console.WriteLine($"{enemy.Name} has dealt {damage} damage.");
                    player.Health -= damage;
                    Console.WriteLine($"{player.Name} is left with {player.Health} health.");
                }
                if (player.Initiative(playerWeapon, playerArmor) < enemy.Initiative(enemyWeapon, enemyArmor))
                {
                    damage = enemy.BasicAttack(player, playerArmor, enemyWeapon, player.LevelDifference(enemy.CharacterLevel));
                    Console.WriteLine($"{enemy.Name} has dealt {damage} damage.");
                    player.Health -= damage;
                    Console.WriteLine($"{player.Name} is left with {player.Health} health.");
                    damage = player.BasicAttack(enemy, enemyArmor, playerWeapon, enemy.LevelDifference(player.CharacterLevel));
                    Console.WriteLine($"{player.Name} has dealt {damage} damage.");
                    enemy.Health -= damage;
                    Console.WriteLine($"{enemy.Name} is left with {enemy.Health} health.");
                }


            }
        }

        public static string PickHeroName()
        {
            string name;
            Console.WriteLine("Wellcome Senshi. May I ask your name?");
            while (true)
            {
                name = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(name) && !name.All(char.IsDigit))
                {
                    break;
                }
                Console.WriteLine("Why you troll me?");
            }
            return name;
        }




    }
}