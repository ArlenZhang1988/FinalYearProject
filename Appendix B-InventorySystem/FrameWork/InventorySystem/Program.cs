using System;

namespace InventorySystem
{
    class Program
    {
      static void Main(string[] args)
        {
            Axe fireAxe = new Axe(new AxeProperty("LagonBurningAxe",25));
            Sword coldSword = new Sword(new SwordProperty("Awared", 10));

            TestManager testManager = new TestManager();
            TestModel testModel = new TestModel();
            TestUI testUI = new TestUI();

            testManager.CreateInventory(testUI,testModel);

            //testManager.AddItemToInventory(fireAxe);
            testManager.AddItemToInventory(coldSword);
            testManager.AddItemToInventory(fireAxe);
            testManager.AddItemToInventory(coldSword);
            testManager.AddItemToInventory(fireAxe);

            testManager.SortItems();

            Console.ReadKey();
        }
    }
}
