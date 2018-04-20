using System;
namespace polymorphyzm
{
	public class table
	{
		private A[] tab;
		public table(int x)
		{
			Random los = new Random();

			tab = new A[x];

			for (int i = 0; i < tab.Length; ++i)
			{
				switch (los.Next(1, 5))
				{
					case 1: tab[i] = new A(los.Next(0, 11)); break;
					case 2: tab[i] = new B(los.Next(10, 21)); break;
					case 3: tab[i] = new C(los.Next(21, 31)); break;
					case 4: tab[i] = new D(los.Next(30, 41), los.Next(30, 41)); break;
				}
			}
		}

		public table(int x, int y)
		{
			tab = new A[x];
		}

		public void myPrint()
		{
			for (int i = 0; i < tab.GetLength(0); i++)
			{
				tab[i].druk();
			}
		}

		public table deepLazyCopy()
		{
			table temp = new table(tab.Length, 2);
			for (int i = 0; i < tab.Length; ++i)
			{
				temp.tab[i] = tab[i];
			}
			return temp;
		}

		public table copy()
		{
			Console.WriteLine("Robimy kopie\n");
			table temp = new table(tab.Length, 2);
			for (int i = 0; i < tab.Length; ++i)
			{
				temp.tab[i] = tab[i].copy();
			}
			return temp;
		}

		public table zamiana()
		{
			int o;

			Random los = new Random();

			tab[o=los.Next(1, tab.Length)].zamiana(o*100);

			Console.WriteLine("dokonalismy zamiane w elemencie nr {0}", o+1);

			return this;
		}
	}
}