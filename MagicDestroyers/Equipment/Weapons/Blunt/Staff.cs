using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Blunt
{
    public class Staff: Weapon
    {
        

        public Staff(): base()
        {
            base.Damage = DEFAULT_DAMAGE_STAFF;
        }

        public void Empower()
        {
            throw new NotImplementedException();
        }
    }
}
