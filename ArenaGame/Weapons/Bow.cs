using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Bow : IWeapon

    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        private Random random;

        public Bow(string name)
        {
            Name = name;
            AttackDamage = 25;
            BlockingPower = 1;
            random = new Random();
        }
        public void SpecialAbility(Hero attacker, Hero defender, double damage)
        {
            double probability = random.NextDouble();
            if (probability < 0.25) 
            {
                double criticalDamage = damage * 1.5; 
                defender.ReceiveDamage(criticalDamage);
                Console.WriteLine($"{attacker.Name} use special abillity and attack {defender.Name}, and cause {Math.Round(criticalDamage, 2)}!");

            }
        }
    }
}
