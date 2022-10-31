using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_6
{
    public class Enemy : Character

    {
        private string _name;
        private int _health;
        private int _stamina;
        private int _damage;
       

        public override string Name { get => _name; set => _name = value; }
        public override int Health { get => _health; set => _health = value; }
        public override int Stamina { get => _stamina; set => _stamina = value; }
        public override int Damage { get => _damage; set => _damage = value; }


        public Enemy()
        {
            Name = "enemy01";
            Health = 100;
            Stamina = 100;
            Damage = 10;

        }

        public override void Attack(ref int enemyHealth)
        {
            if (Stamina > 0)
            {
                enemyHealth = enemyHealth - Damage;
                Stamina = Stamina - 20;
            }
            else
            {
                Wait();
            }
        }

        public override void Wait()
        {
            
            if (Stamina < 100)
            {
                Stamina += 10;

            }
                
        }
    }
}
