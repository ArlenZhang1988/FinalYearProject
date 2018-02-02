namespace InventorySystem
{
    abstract class PotionProperty : ItemProperty
    {
        protected PotionType potionType;
        public PotionType PotionType { get { return potionType; } }

        int factor;

        public PotionProperty()
        {
            itemType = ItemType.POTION;
        }

        public abstract void Initialize(PotionType potionType);

        public override bool FurtherComparison(ItemProperty otherItemProperty)
        {
            PotionProperty temp = (PotionProperty)otherItemProperty;

            int thisPriority = (int)potionType;
            int itemToComparePriority = (int)temp.PotionType;

            if (thisPriority > itemToComparePriority)
            {
                return true;
            }

            return false;
        }
    }
}
