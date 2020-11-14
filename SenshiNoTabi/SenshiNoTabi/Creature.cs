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
            private set => _name = string.IsNullOrWhiteSpace(value) ? "typicalName" : value;
        }
        private int _strength;
        public int Strength
        {
            get => _strength;
            private set => _strength = value < 0 ? 0 : value;
        }

        private int _endurance;
        public int Endurance
        {
            get => _endurance;
            private set => _endurance = value < 0 ? 0 : value;
        }

        public int _health;
        public int Health
        {
            get => _health;
            set => _health = value < 0 ? 0 : value;
        }
        private int _speed;
        public int Speed
        {
            get => _speed;
            private set => _speed = value < 0 ? 0 : value;
        }
        private int _characterLevel;
        public int CharacterLevel
        {
            get => _characterLevel;
            private set => _characterLevel = value < 0 ? 0 : value;
        }
        protected Creature(string name, int strength, int endurance, int health, int speed, int characterLevel)
        {
            Name = name;
            Strength = strength;
            Endurance = endurance;
            Health = health;
            Speed = speed;
            CharacterLevel = characterLevel;
        }

        public int LevelDifference(int enemyLevel)
        {
            return CharacterLevel - enemyLevel;
        }
        
        public int BasicAttack(Creature defenderCreature, Armor defenderArmor, Weapon attackerWeapon, int defenderLevelDifference)
        {
            Random rng = new Random();
            float x = (float)((attackerWeapon.PhysicalAttack * Strength) - (defenderCreature.Endurance * defenderArmor.ArmorDefence * (1 + defenderLevelDifference * 0.05)) * (rng.Next(100, 125) / 100));
            return (int)Math.Round(x);
        }             

        public int Initiative(Weapon attackerWeapon, Armor attackerArmor)
        {
            Random rng = new Random();
            return (Speed * (attackerWeapon.WeaponSpeed - attackerArmor.ArmorWeight)) * (rng.Next(95, 105)/100);
        }

    }
}

