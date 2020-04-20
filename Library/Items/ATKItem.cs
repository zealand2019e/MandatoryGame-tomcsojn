using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Items
{
    class ATKItem:Item
    {
        static List<atkitem> itemlist = new List<atkitem>()
        {
            new atkitem{name = "Wooden Sword", value = 3},
            new atkitem{name = "Iron Sword", value = 5},
            new atkitem{name = "Iron Fist", value = 3},
            new atkitem{name = "Club", value = 1},
            new atkitem{name = "Fire Magic", value = 4},
        };
        struct atkitem
        {
            public string name;
            public int value;
        }


        private ATKItem(string type, int value, string name) : base(type, value, name)
        {

        }

        public static Item GetItem()
        {
            var random = new Random();
            atkitem tmp = itemlist[random.Next(itemlist.Count)];
            Item item = new ATKItem("ATK", tmp.value, tmp.name);
            return item;
        }

    }
}
