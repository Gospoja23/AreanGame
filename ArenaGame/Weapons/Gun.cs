using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Gun : IWeapon

    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        private Random random;

        public Gun(string name)
        {
            Name = name;
            AttackDamage = 25;
            BlockingPower = 10;
            random = new Random();
        }
        public void SpecialAbility(Hero attacker, Hero defender, double damage)
        {
            double probability = random.NextDouble();
            if (probability < 0.2) // 20% шанс нанести двойной урон
            {
                double doubleDamage = damage * 2; // Удвоение урона
                defender.ReceiveDamage(doubleDamage);
                Console.WriteLine($"{attacker.Name} use special abillity and attack {defender.Name}, and cause {Math.Round(doubleDamage, 2)}!");
            }
        }
    }
}
