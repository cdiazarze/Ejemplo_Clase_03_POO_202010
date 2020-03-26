using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Sharp
{
    public class Axe: Weapon
    {
        public Axe(): base()
        {
            base.Damage = DEFAULT_DAMAGE_AXE;
        }

        public void HackNSlash()
        {
            throw new NotImplementedException();
        }
    }
}
