using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Blunt
{
    public class Hammer: Weapon
    {
    
        public Hammer():base()
        {
            base.Damage = DEFAULT_DAMAGE_HAMMER;
        }

        public void Stun()
        {
            throw new NotImplementedException();
        }
    }
}
