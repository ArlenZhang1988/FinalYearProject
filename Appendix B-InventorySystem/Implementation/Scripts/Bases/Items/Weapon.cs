namespace InventorySystem
{
    abstract class Weapon :Item
    {
        public WeaponProperty WeaponProperty { get { return (WeaponProperty)itemProperty; } }

        public override void Use()
        {
            WeaponProperty.ReduceCount();
        }

        public abstract void Attack();
        
        public abstract bool Enhance(int factor); //Enhance method retures a bool value which represents whether the enhancement is succeed.
    }
}