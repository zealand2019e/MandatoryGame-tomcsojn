using System;
using System.Collections.Generic;
using System.Text;
using Library.Items;
namespace Library
{
	public class Creature
	{
		private int posx;

		public int PosX
		{
			get { return posx; }
			set { posx = value; }
		}
		private int posy;
		

		public int PosY
		{
			get { return posy; }
			set { posy = value; }
		}
		List<Item> Items = new List<Item>();
		private int baseatk;
		private int basedef;
		private int basehp;
		private string name;

		public Creature(int posx, int posy, int baseatk, int basedef, int basehp, string name)
		{
			this.posx = posx;
			this.posy = posy;
			this.baseatk = baseatk;
			this.basedef = basedef;
			this.basehp = basehp;
			this.name = name;
		}

		public int GetATK()
		{
			int atkcount = baseatk;
			//atk from items
			foreach (var item in Items.FindAll(x => x.Type == "ATK"))
			{
				atkcount += item.value;
			}
			return atkcount;
		}
		int GetDef()
		{
			int defcount = basedef;
			// defence from items
			foreach (var item in Items.FindAll(x=>x.Type=="DEF"))
			{
				defcount += item.value;
			}


			return defcount;
		}

		public bool defend(int atk)
		{
			atk -= GetDef();
			if (atk > 0)
			{
				basehp -= atk;
				if (basehp <= 0)
				{
					return true;//return true for death
				}
			}
			return false;//return false if survived
		}

		

		public void pickup(Object O)
		{
			Item tmp = O.GetContent;
			if (tmp!=null)
			{
				Items.Add(tmp);
			}
			//object was empty

		}


	}
}
