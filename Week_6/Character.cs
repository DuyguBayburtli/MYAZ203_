using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_6
{
    public  abstract class Character
    {
        public abstract string Name { get; set; } 
        public abstract int Health { get; set; } 
        public abstract int Stamina { get; set; }
        public abstract int Damage { get; set; }
        public abstract void Attack (ref int enemyHealth);
        public abstract void Wait ();
    }
}
