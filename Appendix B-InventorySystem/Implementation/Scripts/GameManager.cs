using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using InventorySystem;

public class GameManager : MonoBehaviour {

    [SerializeField]
    string[] randomItems;

    Random r = new Random();

    UnityInventoryUI toAddEvent;

    private void Start()
    {
        toAddEvent = new UnityInventoryUI();

        UnityInventoryManager.Instance().CreateInventory(toAddEvent,new UnityInventoryModel());

        foreach (var temp in toAddEvent.TempList)
        {
            temp.GetComponent<Button>().onClick.AddListener(()=>UnityInventoryManager.Instance().UseItem(temp.GetComponent<Grid>().GridIndex));
        }

        Button b = GameObject.Find("SortItem_Button").GetComponent<Button>();
        b.onClick.AddListener( () => toAddEvent.SortItem());
        b = GameObject.Find("Clear_Button").GetComponent<Button>();
        b.onClick.AddListener(() => toAddEvent.ClearItems());
    }

    public void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            string itemName = randomItems[Random.Range(0, randomItems.Length)];

            CreateItem(itemName);
        }
    }

    void CreateItem(string itemName)
    {
        GameObject obj = Resources.Load(itemName) as GameObject;

        GameObject go = GameObject.Instantiate<GameObject>(obj);

        Item item = go.GetComponent<Item>();

        if (!UnityInventoryManager.Instance().AddItemToInventory(item))
        {
            Dialogue.Instance().UpdateDialog("The inventory is full");
        }
        else
        {
            Dialogue.Instance().UpdateDialog(item.ItemProperty.ItemName + " is added to the inventory");
        }
    }

    public void ExitApp()
    {
        Application.Quit();
    }
}
