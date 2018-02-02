using System;

namespace InventorySystem
{
    class Sword : Weapon
    {
        public Sword(ItemProperty newItemProperty)
        {
            Initialize(newItemProperty);
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
}
