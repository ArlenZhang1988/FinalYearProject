using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class TestUI : InventoryUI
    {
        public override void InitializeUI()
        {
            gridArray = new Grid[10];

            for (int i = 0; i < gridArray.Length; i++)
            {
                gridArray[i] = new TestGrid();
            }
        }

        public override void SortItem()
        {
            throw new NotImplementedException();
        }

        public override void UseItem()
        {
            throw new NotImplementedException();
        }
    }
}