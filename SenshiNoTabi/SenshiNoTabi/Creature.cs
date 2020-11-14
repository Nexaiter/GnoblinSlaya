using System;
using System.Collections.Generic;
using System.Text;

namespace SenshiNoTabi
{
    public abstract class Creature
    {
        private string _name;
        public string Name
        {
            get => _name;
            private set => _name = string.IsNullOrWhiteSpace(value) ? "typicalName"  : value; 
        }
        private int _attack;
        public int Attack
        {
            get => _attack;
            private set => _attack = value < 0 ? 0 : value; 
        }

        private int _defense;
        public int Defense
        {
            get => _defense;
            private set => _defense = value < 0 ? 0 : value; 
        }

        private int _health;
        public int Health
        {
            get => _health;
            private set => _health = value < 0 ? 0 : value;
        }
        private int _speed;
        public int Speed
        {
            get => _speed;
            private set => _speed = value < 0 ? 0 : value;
        }
        protected Creature(string name, int attack, int defense, int health, int speed)
        {
            Name = name;
            Attack = attack;
            Defense = defense;
            Health = health;
            Speed = speed;
        }

        public int DamageAfterDefense(int enemyAttack)
        { 
            return ((enemyAttack - Defense) > 0) ? enemyAttack - Defense : 0;
        }

        public void DamageTaken(int enemyDamage, string name)
        {
            Health -= enemyDamage;
            Console.WriteLine($"{name} {Health}HP remaining");
        }

        public int Hit(string name, int attack, int enemyDefense, int damageAfterDefense)
        {
            Console.WriteLine($"{name} hit for {damageAfterDefense}({attack}attack - {enemyDefense}defense) damage");
            return damageAfterDefense;
        }

    }
}

