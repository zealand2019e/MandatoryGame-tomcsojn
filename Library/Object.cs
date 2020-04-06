using System;
using System.Collections.Generic;
using System.Text;
using Library.Items;

namespace Library
{
     public class Object
    {

		private int posx;

		public int Posx
		{
			get { return posx; }
			
		}
		private int posy;

		public int Posy
		{
			get { return posy; }
			
		}

		private Item content;

		public Item GetContent
		{
			get {
				Item tmp = content;
				content = null;
				return tmp; }
			
		}

		public Object(int posx, int posy, Item content)
		{
			this.posx = posx;
			this.posy = posy;
			this.content = content;
		}
	}
}
