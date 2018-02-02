using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using InventorySystem;

class UnityInventoryUI : InventoryUI
{
    GameObject UI;

    protected List<Grid> tempList = new List<Grid>();
    public List<Grid> TempList { get { return tempList; } }

    public override void InitializeUI()
    {
        UI = GameObject.Find("InventoryUI");

        InitNodes(UI.transform);

        gridArray = new Grid[tempList.Count];

        for (int i = 0; i < tempList.Count; i++)
        {
            gridArray[i] =  tempList.ElementAt(i);
            Grid grid = tempList.ElementAt(i);
            grid.SetIndex(i);
        }
    }

    void InitNodes(Transform trans)
    {
        if (trans.name == "Grid")
        {
            tempList.Add(trans.gameObject.AddComponent<UnityGrid>());
        }

        for (int i = 0; i < trans.childCount; i++)
        {
            InitNodes(trans.GetChild(i));
        }
    }

    public override void SortItem()
    {
        inventoryManager.SortItems();
    }

    public override void UseItem()
    {
        throw new NotImplementedException();
    }

    public override void ClearItems()
    {
        inventoryManager.ClearItem();
    }
}
