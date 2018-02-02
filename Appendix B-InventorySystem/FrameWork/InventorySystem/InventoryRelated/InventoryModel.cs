namespace InventorySystem
{
    abstract class InventoryModel
    {
        Item[] itemArray;

        public event UpdateAfterAddItem AddItemDele;
        public event UpdateAfterSortItem SortItemDele;
        public event UpdateAfterUseItem UseItemDele;

        public InventoryModel()
        {
            Initialize();
        }

        public abstract void Initialize();

        public void SetItemArray(int gridCount)
        {
            itemArray = new Item[gridCount];
        }

        public bool AddItem(Item newItem)
        {
            for (int i = 0; i < itemArray.Length; i++)
            {
                if (itemArray[i] != null && itemArray[i].ItemProperty.ItemName == newItem.ItemProperty.ItemName)
                {
                    if (itemArray[i].AddItem(newItem.ItemProperty.ItemCount))
                    {
                        AddItemDele(newItem,i);

                        return true;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (itemArray[i] == null)
                {
                    itemArray[i] = newItem;

                    AddItemDele(newItem,i);

                    return true;
                }
            }

            return false;
        }

        public void SortItem()
        {
            Item temp;

            for (int i = 0; i < itemArray.Length-1; i++)
            {
                for (int j = i+1; j < itemArray.Length; j++)
                {
                    if (itemArray[i] !=null && itemArray[j] !=null)
                    {
                        if (itemArray[j].CompareItem(itemArray[i]))
                        {
                            temp = itemArray[i];
                            itemArray[i] = itemArray[j];
                            itemArray[j] = temp;
                        }
                    }
                }
            }

            SortItemDele( itemArray);
        }

        public void UseItem(int gridIndex)
        {
            itemArray[gridIndex].Use();

            if (itemArray[gridIndex].ItemProperty.ItemCount<=0)
            {
                UseItemDele(itemArray[gridIndex],gridIndex);
            }
        }
    }
}
