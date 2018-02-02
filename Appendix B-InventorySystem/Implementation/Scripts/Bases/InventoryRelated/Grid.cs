using UnityEngine;

namespace InventorySystem
{
    abstract class Grid : MonoBehaviour
    {
        protected Item item;
        public Item Item { get { return item; } }

        protected int gridIndex;
        public int GridIndex { get { return gridIndex; } }

        public void AddItem(Item newItem)
        {
            item = newItem;

            UpdateUI();

            Debug.Log(newItem.ItemProperty.ItemCount);
        }

        public void SetIndex(int index)
        {
            gridIndex = index;
        }

        public void RemoveItem()
        {
            item = null;

            UpdateUIAfterRemove();
        }

        public abstract void UpdateUI();
        public abstract void UpdateUIAfterRemove();
    }
}
