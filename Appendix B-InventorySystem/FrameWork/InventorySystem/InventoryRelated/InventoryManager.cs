namespace InventorySystem
{
    abstract class InventoryManager
    {
        InventoryModel inventoryModel;

        public void CreateInventory(InventoryUI newInventoryUI,InventoryModel newInventoryModel)
        {
            newInventoryUI.SetUpDel(newInventoryModel);
            newInventoryUI.SetManager(this);

            inventoryModel = newInventoryModel;
            inventoryModel.SetItemArray(newInventoryUI.ReturnGridCount());
        }

        public bool AddItemToInventory(Item newItem)
        {
            bool addItemSucceed = inventoryModel.AddItem(newItem);

            return addItemSucceed;
        }

        public void SortItems()
        {
            inventoryModel.SortItem();
        }

        public void UseItem(int gridIndex)
        {
            inventoryModel.UseItem(gridIndex);
        }
    }
}
