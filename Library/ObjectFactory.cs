using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class ObjectFactory
    {

        int lenght, width;

        public ObjectFactory(int lenght, int width)
        {
            this.lenght = lenght;
            this.width = width;
        }

        public Object GetObject()
        {
            Random random = new Random();
            Object o = new Object(random.Next(0, lenght), random.Next(0, width), Library.Items.ItemFactory.GetItem());
            return o;
        }
    }
}
