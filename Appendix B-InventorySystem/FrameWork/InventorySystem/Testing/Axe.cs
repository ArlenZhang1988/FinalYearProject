using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Axe : Weapon
    {
        public Axe(ItemProperty newItemProperty)
        {
            Initialize(newItemProperty);
        }

        public override void Attack()
        {
            Console.WriteLine("Attacking using {0} Damage {1}", WeaponProperty.ItemName, WeaponProperty.WeaponDamage);
        }

        public override bool Enhance(int factor)
        {
            WeaponProperty.EnhanceProperty(factor);

            Console.WriteLine("{0} is enhanced + {1}", WeaponProperty.ItemName, factor);
            return true;
        }

        public override string ToString()
        {
            return WeaponProperty.ItemCount.ToString();
        }
    }
}