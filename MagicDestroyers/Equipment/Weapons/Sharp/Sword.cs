using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Sharp
{
    public class Sword: Weapon
    {

        public Sword(): base()
        {
            base.Damage = DEFAULT_DAMAGE_SWORD;
        }

        public void Bloodthirst()
        {
            throw new NotImplementedException();
        }
    }
}
