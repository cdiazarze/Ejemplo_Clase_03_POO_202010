using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Necromancer: Spellcaster
    {
        public Necromancer() : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }

        public Necromancer(string name, int level) : this(name, level, DEFAULT_MANA_POINTS)
        {
        }

        public Necromancer(string name, int level, int healthPoints) : base(name, level, healthPoints)
        {
            this.BodyArmor = new LightLeatherVest();
            this.Weapon = new Sword();
        }

        public void ShadowRage()
        {
            throw new NotImplementedException();
        }

        public void VampireTouch()
        {
            throw new NotImplementedException();
        }

        public void BoneShield()
        {
            throw new NotImplementedException();
        }
    }
}
