using System.Collections.Generic;

namespace InventorySystem
{
    abstract class InventoryModel
    {
        protected  Item[] itemArray;
        public Item[] ItemArray { get { return itemArray; } }

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
                        AddItemDele(itemArray[i], i);

                        return true;
                    }
                }
            }

            for (int i = 0; i < itemArray.Length; i++)
            {
                if (itemArray[i] == null)
                {
                    itemArray[i] = newItem;

                    AddItemDele(itemArray[i], i);

                    return true;
                }
            }

            return false;
        }

        public void SortItem()
        {
            List<Item> tempList = new List<Item>();
             
            for (int i = 0; i < itemArray.Length; i++)
            {
                if (itemArray[i]!=null)
                {
                    tempList.Add(itemArray[i]);

                    itemArray[i] = null;
                }
            }

            for (int i = 0; i < tempList.Count; i++)
            {
                itemArray[i] = tempList.ToArray()[i];
            }

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
            if (itemArray[gridIndex] == null)
            {
                return;
            }

            itemArray[gridIndex].Use();

            if (itemArray[gridIndex].ItemProperty.ItemCount>0)
            {
                UseItemDele(itemArray[gridIndex],gridIndex);
            }
            else
            {
                itemArray[gridIndex] = null;
                UseItemDele(null, gridIndex);
            }
        }

        public void Clear()
        {
            for (int i = 0; i < itemArray.Length; i++)
            {
                itemArray[i] = null;
            }

            SortItemDele(itemArray);
        }
    }
}
