using System;
using System.Collections; //pilne dla list wbudowanych!

namespace listIncludedInLanguage2
{
	class A
	{
		public int x;
		public A(int px)
		{
			x = px;
		}

		public override string ToString()
		{
			return ("A.x=" + x.ToString());
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			ArrayList lista = new ArrayList();
			lista.Add("ala ma kota");
			lista.Add(14);

			lista.Add(new A(1113));

			Console.WriteLine(lista[2]);
			Console.WriteLine((A)lista[2]);

			Console.WriteLine(((A)lista[2]).x);

			for (int i = 0; i < lista.Count; ++i)
			{
				Console.WriteLine(lista[i]);
			}
			Console.ReadKey();
		}
	}
}