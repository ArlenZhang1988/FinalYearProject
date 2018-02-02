using UnityEngine;

namespace InventorySystem
{
    abstract class WeaponProperty : ItemProperty
    {
        protected WeaponType weaponType;
        public WeaponType WeaponType { get { return weaponType; } }

        [SerializeField]
        protected int weaponDamage;
        public int WeaponDamage { get { return weaponDamage; } }

        public WeaponProperty()
        {
            itemType = ItemType.WEAPON;

            Initialize();
        }

        public abstract void Initialize();

        public abstract void EnhanceProperty(int factor);

        public override bool FurtherComparison(ItemProperty otherItemProperty)
        {
            WeaponProperty temp = (WeaponProperty)otherItemProperty;

            int thisPriority = (int)weaponType;
            int itemToComparePriority = (int)temp.WeaponType;

            if (thisPriority > itemToComparePriority)
            {
                return true;
            }

            return false;
        }
    }
}
