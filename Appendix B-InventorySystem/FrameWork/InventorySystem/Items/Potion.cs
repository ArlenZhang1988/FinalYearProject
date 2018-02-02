namespace InventorySystem
{
    abstract class Potion : Item
    {
        public PotionProperty PotionProperty { get { return (PotionProperty)itemProperty; } }

        protected override void Initialize(ItemProperty newItemProperty)
        {
            itemProperty = newItemProperty;

            canStack = true;
        }

        public override void Use()
        {
            PotionProperty.ReduceCount();
        }

        public abstract void PotionEffect();
    }
}