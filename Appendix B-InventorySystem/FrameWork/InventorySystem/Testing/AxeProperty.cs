using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class AxeProperty : WeaponProperty
    {
        public AxeProperty(string axeName, int axeDamage)
        {
            itemName = axeName;

            weaponDamage = axeDamage;

            Initialize();
        }

        public override void EnhanceProperty(int factor)
        {
            weaponDamage += factor;
        }

        public override void Initialize()
        {
            weaponType = WeaponType.AXE;
        }
    }
}
