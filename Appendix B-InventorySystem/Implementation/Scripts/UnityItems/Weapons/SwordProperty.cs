using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using InventorySystem;

class SwordProperty : WeaponProperty
{
    public override void EnhanceProperty(int factor)
    {
        throw new NotImplementedException();
    }

    public override void Initialize()
    {
        weaponType = WeaponType.SWORD;
    }
}
