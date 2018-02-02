using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using InventorySystem;

class HealthPotionProperty : PotionProperty
{
    public override void Initialize(PotionType potionType)
    {
        potionType = PotionType.HEALTHPOTION;
    }
}