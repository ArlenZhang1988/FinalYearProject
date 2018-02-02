using System;
using UnityEngine;

namespace InventorySystem
{
    abstract class ItemProperty : MonoBehaviour
    {
        [SerializeField]
        protected String itemName;
        public String ItemName { get { return itemName; } }

        [SerializeField]
        protected int itemCount;
        public int ItemCount { get { return itemCount; } }

        protected ItemType itemType;
        public ItemType ItemType { get { return itemType; } }

        [SerializeField]
        protected Sprite uiSprite;
        public Sprite UISprite {get{ return uiSprite; } }

        [SerializeField]
        protected bool canStack;
        public bool CanStack { get { return canStack; } set { canStack = value; } }

        public ItemProperty()
        {
            itemCount = 1;
        }

        public void ReduceCount()
        {
            itemCount -= 1;
        }

        public void AddItemCount(int newCount)
        {
            itemCount += 1;
        }

        public abstract bool FurtherComparison(ItemProperty otherItemProperty);
    }
}