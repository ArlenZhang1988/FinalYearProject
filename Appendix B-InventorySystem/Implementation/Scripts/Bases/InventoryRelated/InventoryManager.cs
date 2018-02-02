namespace InventorySystem
{
    abstract class InventoryManager
    {
        protected InventoryModel inventoryModel;

        public virtual void CreateInventory(InventoryUI newInventoryUI,InventoryModel newInventoryModel)
        {
            newInventoryUI.SetUpDel(newInventoryModel);
            newInventoryUI.SetManager(this);

            inventoryModel = newInventoryModel;
            inventoryModel.SetItemArray(newInventoryUI.ReturnGridCount());
        }

        public virtual bool AddItemToInventory(Item newItem)
        {
            bool addItemSucceed = inventoryModel.AddItem(newItem);

            return addItemSucceed;
        }

        public virtual void SortItems()
        {
            inventoryModel.SortItem();
        }

        public virtual void UseItem(int gridIndex)
        {
            inventoryModel.UseItem(gridIndex);
        }

        public virtual void ClearItem()
        {
            inventoryModel.Clear();
        }
    }
}
