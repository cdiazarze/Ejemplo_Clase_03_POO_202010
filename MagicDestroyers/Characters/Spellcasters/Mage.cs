using MagicDestroyers.Equipment.Armors.Light;
using MagicDestroyers.Equipment.Weapons.Blunt;
using System;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Mage: Spellcaster
    {


        public Mage() : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }

        public Mage(string name, int level) : this(name, level, DEFAULT_MANA_POINTS)
        {
        }

        public Mage(string name, int level, int healthPoints) : base(name, level, healthPoints)
        {
            this.BodyArmor = new ClothRobe();
            this.Weapon = new Staff();
        }

        public void Fireball()
        {
            throw new NotImplementedException();
        }

        public void ArcaneWrath()
        {
            throw new NotImplementedException();
        }

        public void Meditation()
        {
            throw new NotImplementedException();
        }
    }
}
