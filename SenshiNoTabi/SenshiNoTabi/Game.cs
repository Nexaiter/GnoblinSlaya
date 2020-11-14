using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading;

namespace SenshiNoTabi
{
    public static class Game
    {
        public static void Fight(Player player, Enemy enemy)
        {
            while (player.Health > 0 && enemy.Health > 0)
            {
                if (player.Speed > enemy.Speed)
                {
                    enemy.DamageTaken(player.Hit(player.Name, player.Attack, enemy.Defense, enemy.DamageAfterDefense(player.Attack)), enemy.Name);
                    player.DamageTaken(enemy.Hit(enemy.Name, enemy.Attack, player.Defense, player.DamageAfterDefense(enemy.Attack)), player.Name);
                }
                else
                {
                    player.DamageTaken(enemy.Hit(enemy.Name, enemy.Attack, player.Defense, player.DamageAfterDefense(enemy.Attack)), player.Name);
                    enemy.DamageTaken(player.Hit(player.Name, player.Attack, enemy.Defense, enemy.DamageAfterDefense(player.Attack)), enemy.Name);
                }

                Console.ReadKey();
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


        //public static int PickAttack(string name) {}


    }
}