namespace InventorySystem
{
    abstract class Item
    {
        protected ItemProperty itemProperty;
        public ItemProperty ItemProperty { get { return itemProperty; } }

        protected bool canStack;

        public abstract void Use();

        protected abstract void Initialize(ItemProperty newItemProperty);

        public virtual bool AddItem(int newCount)
        {
            if (canStack)
            {
                itemProperty.AddItemCount(newCount);
                return true;
            }

            return false;
        }

        public bool CompareItem(Item itemToCompare)
        {
            int thisPriority = (int)itemProperty.ItemType;
            int itemToComparePriority = (int)itemToCompare.itemProperty.ItemType;

            bool sameItemTypeCompare = false;

            if (thisPriority > itemToComparePriority)
            {
                return true;
            }
            else if(thisPriority == itemToComparePriority)
            {
                sameItemTypeCompare = itemProperty.FurtherComparison(itemToCompare.ItemProperty);
            }

            return sameItemTypeCompare;
        }
    }
}
