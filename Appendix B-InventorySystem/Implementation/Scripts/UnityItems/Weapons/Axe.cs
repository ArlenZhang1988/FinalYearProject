using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using InventorySystem;

class Axe : Weapon
{
    public void Awake()
    {
        Initialize(GetComponent<AxeProperty>());
    }

    public override void Attack()
    {
        throw new NotImplementedException();
    }

    public override bool Enhance(int factor)
    {
        throw new NotImplementedException();
    }
}
