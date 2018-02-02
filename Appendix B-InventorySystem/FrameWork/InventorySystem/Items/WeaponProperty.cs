namespace InventorySystem
{
    abstract class WeaponProperty : ItemProperty
    {
        protected WeaponType weaponType;
        public WeaponType WeaponType { get { return weaponType; } }

        protected int weaponDamage;
        public int WeaponDamage { get { return weaponDamage; } }

        public WeaponProperty()
        {
            itemType = ItemType.WEAPON;
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
