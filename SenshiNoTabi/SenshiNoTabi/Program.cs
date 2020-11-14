using System;

namespace SenshiNoTabi
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(Game.PickHeroName(), 10, 20, 100, 5);
            Enemy enemy = new Enemy("Nexaiter",6,5,5,5);
            Game.Fight(player,enemy);
        }
    }
}
