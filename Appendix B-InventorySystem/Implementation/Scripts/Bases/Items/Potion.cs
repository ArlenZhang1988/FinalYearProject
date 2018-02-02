namespace InventorySystem
{
    abstract class Potion : Item
    {
        public PotionProperty PotionProperty { get { return (PotionProperty)itemProperty; } }

        public override void Use()
        {
            PotionProperty.ReduceCount();
        }

        public abstract void PotionEffect();
    }
}