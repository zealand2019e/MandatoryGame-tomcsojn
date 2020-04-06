using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Items
{
    public class Item
    {
        string Type { get; set; }
        int value { get; set; }

        string Name { get; set; }

        public Item(string type, int value, string name)
        {
            Type = type;
            this.value = value;
            Name = name;
        }
    }
}
