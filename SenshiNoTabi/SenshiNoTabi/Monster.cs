using System;
using System.Collections.Generic;
using System.Text;

namespace SenshiNoTabi
{
     public class Monster : Creature
    {
        public Monster(string name, int strength, int endurance, int health, int speed, int characterLevel) : base(name, strength, endurance, health, speed, characterLevel)
        {

        }
    }
}
