using UnityEngine;

namespace InventorySystem
{
    abstract class Item : MonoBehaviour
    {
        protected ItemProperty itemProperty;
        public ItemProperty ItemProperty { get { return itemProperty; } }

        public abstract void Use();

        protected void Initialize(ItemProperty newItemProperty)
        {
            itemProperty = newItemProperty;
        }

        public virtual bool AddItem(int newCount)
        {
            if (itemProperty.CanStack)
            {
                itemProperty.AddItemCount(newCount);
                return true;
            }

            return false;
        }

        public bool CompareItem(Item itemToCompare)
        {
            int thisPriority = (int)itemProperty.ItemType;
            int itemToComparePriority = (int)itemToCompare.itemProperty.ItemType;

            bool sameItemTypeCompare = false;

            if (thisPriority > itemToComparePriority)
            {
                return true;
            }
            else if(thisPriority == itemToComparePriority)
            {
                sameItemTypeCompare = itemProperty.FurtherComparison(itemToCompare.ItemProperty);
            }

            return sameItemTypeCompare;
        }
    }
}
