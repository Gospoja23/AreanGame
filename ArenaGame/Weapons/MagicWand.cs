using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{

    public class MagicWand : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }


        public MagicWand(string name)
        {
            Name = name;
            AttackDamage = 10;
            BlockingPower = 10;

        }
        public void SpecialAbility(Hero attacker, Hero defender, double damage)
        {
            double healing = damage * 0.2; 
            attacker.Heal(healing);
            Console.WriteLine($"{attacker.Name} healed {Math.Round(healing, 2)} of damage with wand");
        }

    }
}
