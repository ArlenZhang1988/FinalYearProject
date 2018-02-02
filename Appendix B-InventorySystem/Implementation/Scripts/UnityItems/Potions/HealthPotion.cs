using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using InventorySystem;

class HealthPotion : Potion
{
    public void Awake()
    {
        Initialize(GetComponent<HealthPotionProperty>());
    }

    public override void PotionEffect()
    {
        throw new NotImplementedException();
    }
}
