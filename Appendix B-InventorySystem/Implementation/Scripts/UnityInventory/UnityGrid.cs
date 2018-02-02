using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine.UI;
using InventorySystem;
using UnityEngine;

class UnityGrid : Grid
{
    protected Sprite preSprite;
    protected Text counter;

    public void Awake()
    {
        preSprite = gameObject.transform.Find("Image").GetComponent<Image>().sprite;
        counter = gameObject.transform.GetComponentInChildren<Text>();
    }

    public override void UpdateUI()
    {
        gameObject.transform.Find("Image").GetComponent<Image>().sprite = item.ItemProperty.UISprite; ;

        counter.text = item.ItemProperty.ItemCount.ToString();
    }

    public override void UpdateUIAfterRemove()
    {
        gameObject.transform.Find("Image").GetComponent<Image>().sprite = null ;

        counter.text = 0.ToString();
    }
}