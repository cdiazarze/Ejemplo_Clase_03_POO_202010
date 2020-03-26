using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;

namespace MagicDestroyers.Characters.Melee
{
    public class Assassin: Melee
    {
        public Assassin() : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }

        public Assassin(string name, int level) : this(name, level, DEFAULT_ABILTY_POINTS)
        {
        }

        public Assassin(string name, int level, int healthPoints) : base(name, level, healthPoints)
        {
            this.BodyArmor = new LightLeatherVest();
            this.Weapon = new Sword();
        }

        public void Raze()
        {
            throw new NotImplementedException();
        }

        public void BleedToDeath()
        {
            throw new NotImplementedException();
        }

        public void Survival()
        {
            throw new NotImplementedException();
        }
    }
}
