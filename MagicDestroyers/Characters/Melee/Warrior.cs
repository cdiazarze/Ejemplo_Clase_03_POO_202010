using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;

namespace MagicDestroyers.Characters.Melee
{
    public class Warrior: Melee
    {
        /*
        private Armor bodyArmor;
        private Weapon weapon;

        public Armor BodyArmor
        {
            get
            {
                return this.bodyArmor;
            }
            set
            {
                this.bodyArmor = value;
            }
        }
        public Weapon Weapon
        {
            get
            {
                return this.weapon;
            }
            set
            {
                this.weapon = value;
            }
        }
        */
        public Warrior(): this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }

        public Warrior(string name, int level): this(name, level, DEFAULT_ABILTY_POINTS)
        {
        }

        public Warrior(string name, int level, int healthPoints): base(name, level, healthPoints)
        {
            this.BodyArmor = new Chainlink();
            this.Weapon = new Axe();
        }

        public void Strike()
        {
            Console.WriteLine("Me WARRIOR STRIKE!");
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }

        public void SkinHarden()
        {
            throw new NotImplementedException();
        }
        
    }
}
