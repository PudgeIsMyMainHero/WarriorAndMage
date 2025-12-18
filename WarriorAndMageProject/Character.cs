using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WarriorAndMageProject
{
    
    public abstract class Character : IDealDamage
    {
        protected int health;
        protected int maxHealth;
        protected int baseDamage;
        protected string name;
        
        public int Health
        {
            get
            {
                return health;
            }
        }

        public int BaseDamage
        {
            get
            {
                return baseDamage;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public Character (int maxHealth, int baseDamage, string name)
        {
            this.maxHealth = maxHealth;
            this.health = this.maxHealth;
            this.baseDamage = baseDamage;
            this.name = name;
        }

        public abstract void Attack();

        public virtual void ApplyDamage(int damage)
        {
            int newHealth = health - damage;

            if(newHealth < 0)
            {
                newHealth = 0;
            }

            health = newHealth;
        }
    }
}
