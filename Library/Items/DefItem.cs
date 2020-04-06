using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Items
{
    class DefItem: Item
    {
        static List<defitem> itemlist = new List<defitem>()
        {
            new defitem{name = "Wooden Shield", value = 3},
            new defitem{name = "Iron Shield", value = 5},
            new defitem{name = "Helmet", value = 3},
            new defitem{name = "Boots", value = 1},
            new defitem{name = "Chestplate", value = 4},
        };
        struct defitem
        {
            public string name;
            public int value;
        }


        private DefItem(string type, int value, string name) : base(type, value, name)
        {

        }

        public static Item GetItem()
        {
            var random = new Random();
            defitem tmp = itemlist[random.Next(itemlist.Count)];
            Item item = new DefItem("DEF", tmp.value, tmp.name);
            return item;
        }
    }


}
