
namespace InventorySystem
{
    class SwordProperty : WeaponProperty
    {
        public SwordProperty(string swordName, int swordDamage)
        {
            itemName = swordName;

            weaponDamage = swordDamage;

            Initialize();
        }

        public override void EnhanceProperty(int factor)
        {
            weaponDamage += factor;
        }

        public override void Initialize()
        {
            weaponType = WeaponType.SWORD;
        }
    }
}
