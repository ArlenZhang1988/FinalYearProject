using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using InventorySystem;

class ManaPotion : Potion
{
    public void Awake()
    {
        Initialize(GetComponent<ManaPotionProperty>());
    }

    public override void PotionEffect()
    {
        throw new NotImplementedException();
    }
}
