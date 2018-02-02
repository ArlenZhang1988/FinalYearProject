using System;

namespace InventorySystem
{
    abstract class ItemProperty
    {
        protected String itemName;
        public String ItemName { get { return itemName; } }

        protected int itemCount;
        public int ItemCount { get { return itemCount; } }

        protected ItemType itemType;
        public ItemType ItemType { get { return itemType; } }

        public ItemProperty()
        {
            itemCount = 1;
        }

        public void ReduceCount()
        {
            itemCount -= 1;
        }

        public void AddItemCount(int newCount)
        {
            itemCount += newCount;
        }

        public abstract bool FurtherComparison(ItemProperty otherItemProperty);
    }
}
