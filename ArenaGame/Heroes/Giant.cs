using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Giant:Hero
    {
        public Giant(string name, double armor, double strenght, IWeapon weapon) :
            base(name, armor, strenght, weapon)
        {
            Health *= 1.25;

        }




        public override double Attack()
        {
            double probability = random.NextDouble();

            if (probability < 0.001)
            {
                Console.WriteLine($"{Name} performed an instant kill!");

                return 120;
            }

            if (probability < 0.15)
            {
                Console.WriteLine($"{Name} skipped the turn!");

                return 0; 
            }

            
            return base.Attack();
        }
        public override double Defend(double damage)
        {
            return base.Defend(damage);
        }

        public override void ReceiveDamage(double damage)
        {
            base.ReceiveDamage(damage);
            if (Health < 0) Health = 0;
        }
    }
}
