using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Items
{
    class ItemFactory
    {
        public static Item GetItem()
        {
            Random random = new Random();
            if (random.Next(1) < 0)
                return ATKItem.GetItem();
            else
                return DefItem.GetItem();

        }
    }
}
