using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Wizard : Hero
    {
        
        public Wizard(string name, double armor, double strenght, IWeapon weapon) :
            base(name, armor, strenght, weapon)
        {
        }




        public override double Attack()
        {
            double damage = base.Attack();

            double probability = random.NextDouble();
            if (probability < 0.2) 
            {
                double healing = damage * 0.2; 
                Health += healing;
                Console.WriteLine($"{Name} healed {Math.Round(healing, 2)} health!");
            }

            return damage;
        }
        public override void ReceiveDamage(double damage)
        {
            base.ReceiveDamage(damage);
            if (Health < 0) Health = 0;
        }

    }
}

