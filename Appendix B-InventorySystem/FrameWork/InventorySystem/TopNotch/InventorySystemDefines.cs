namespace InventorySystem
{
    enum ItemType : int { WEAPON = 5, POTION = 3 }

    enum WeaponType: int {AXE = 10, SWORD = 8}

    enum PotionType : int { }

    delegate void UpdateAfterAddItem(Item newItem, int itemIndex);
    delegate void UpdateAfterSortItem(Item[] items);
    delegate void UpdateAfterUseItem(Item newItem, int itemIndex);
}
