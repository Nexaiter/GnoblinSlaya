using System;

namespace SenshiNoTabi
{
    class Program
    {
        static void Main(string[] args)
        {

            //Adventurers
            Player Argo = new Player("Argo", 100, 50, 500, 60, 1);
            Weapon ArgoWeapon = new Weapon("Fire and Thunder Sword", 30, 30);
            Armor ArgoArmor = new Armor("Breastplate", 30, 40);
            //Monsters
            Monster Gnoblin = new Monster("Gnoblin", 40, 20, 250, 70, 1);
            Weapon GnoblinWeapon = new Weapon("Club", 15, 40);
            Armor GnoblinArmor = new Armor("Rags", 10, 0);

            Game.Fight(Argo, Gnoblin, ArgoWeapon, GnoblinWeapon, ArgoArmor, GnoblinArmor);
        }
    }
}
