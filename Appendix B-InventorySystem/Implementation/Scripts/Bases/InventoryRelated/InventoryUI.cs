using UnityEngine;

namespace InventorySystem
{
    abstract class InventoryUI : MonoBehaviour
    {
        protected Grid[] gridArray;

        protected InventoryManager inventoryManager;

        public InventoryUI()
        {
            InitializeUI();
        }

        public abstract void InitializeUI();

        public void SetManager(InventoryManager _inventoryManager)
        {
            inventoryManager = _inventoryManager;
        }

        public virtual void SetUpDel(InventoryModel newInventoryModel)
        {
            newInventoryModel.AddItemDele += UpdateAfterAddItem;
            newInventoryModel.SortItemDele += UpdateAfterSortItem;
            newInventoryModel.UseItemDele += UpdateAfterUseItem;
        }

        public abstract void UseItem();
        public abstract void SortItem();
        public abstract void ClearItems();

        public void UpdateAfterAddItem(Item newItem,int itemIndex)
        {
            gridArray[itemIndex].AddItem( newItem);
        }

        public void UpdateAfterSortItem( Item[] itemArray)
        {
            for (int i = 0; i < itemArray.Length; i++)
            {
                if (itemArray[i]!=null)
                {
                    gridArray[i].AddItem(itemArray[i]);
                }
                else
                {
                    gridArray[i].RemoveItem();
                }
            }
        }

        public void UpdateAfterUseItem(Item newItem,int itemIndex)
        {
            if (newItem == null)
            {
                gridArray[itemIndex].RemoveItem();
            }
            else
            {
                gridArray[itemIndex].AddItem(newItem);
            }
        }

        public int ReturnGridCount()
        {
            return gridArray.Length;
        }
    }
}