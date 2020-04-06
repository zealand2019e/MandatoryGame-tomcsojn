using System;
using System.Collections.Generic;
using System.Text;

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
			//TODO:add atk from items

			return atkcount;
		}
		 int GetDef()
		{
			int defcount = basedef;
			//TODO:add defence from items

			return defcount;
		}

		public bool defend(int atk)
		{
			atk -= GetDef();
			if (atk>0)
			{
				basehp -= atk;
				if(basehp <=0)
				{
					return true;//return true for death
				}				
			}
			return false;//return false if survived
		}



	}
}
