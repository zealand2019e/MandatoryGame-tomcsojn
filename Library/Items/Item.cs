using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Items
{
    public class Item
    {
        public string Type { get; set; }
        public int value { get; set; }

        public string Name { get; set; }

        public Item(string type, int value, string name)
        {
            Type = type;
            this.value = value;
            Name = name;
        }
    }
}
