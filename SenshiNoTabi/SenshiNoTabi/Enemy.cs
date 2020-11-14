using System;
using System.Collections.Generic;
using System.Text;

namespace SenshiNoTabi
{
     public class Enemy : Creature
    {
        public Enemy(string name, int attack, int defense, int health, int speed) : base(name, attack, defense, health,
            speed)
        {

        }
    }
}
