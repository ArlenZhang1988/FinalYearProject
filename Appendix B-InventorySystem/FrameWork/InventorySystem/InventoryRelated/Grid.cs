namespace InventorySystem
{
    abstract class Grid
    {
        protected Item item;
        public Item Item { get { return item; } }

        int gridIndex;

        public void AddItem(Item newItem)
        {
            item = newItem;
        }

        public void SetIndex(int index)
        {
            gridIndex = index;
        }

        public void RemoveItem()
        {
            item = null;
        }

        public abstract void UpdateUI();
    }
}
