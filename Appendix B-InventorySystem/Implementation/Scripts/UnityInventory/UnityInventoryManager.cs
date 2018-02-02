using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine.UI;
using UnityEngine;
using InventorySystem;

class UnityInventoryManager:InventoryManager
{
    private static UnityInventoryManager instance;

    private UnityInventoryManager() { }

    public static UnityInventoryManager Instance()
    {
        if (instance == null)
        {
            instance = new UnityInventoryManager();
        }

        return instance;
    }

    public override void CreateInventory(InventoryUI newInventoryUI, InventoryModel newInventoryModel)
    {
        base.CreateInventory(newInventoryUI, newInventoryModel);
    }

    public override bool AddItemToInventory(Item newItem)
    {
        return base.AddItemToInventory(newItem);
    }

    public override void ClearItem()
    {
        base.ClearItem();

        Dialogue.Instance().UpdateDialog("The inventory is cleared");
    }

    public override void SortItems()
    {
        base.SortItems();

        Dialogue.Instance().UpdateDialog("The inventory is sorted");
    }

    public override void UseItem(int gridIndex)
    {
        Dialogue.Instance().UpdateDialog(inventoryModel.ItemArray[gridIndex].ItemProperty.ItemName + " is used");

        base.UseItem(gridIndex);
    }
}
