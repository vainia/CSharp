using System;
using System.Collections; //pilne dla list wbudowanych!

namespace listIncludedInLanguage
{
	class Program
	{
		static void Main(string[] args)
		{
			ArrayList lista = new ArrayList();
			lista.Add("ala ma kota");
			lista.Add(14);

			for (int i = 0; i < lista.Count; ++i)
			{
				Console.WriteLine(lista[i]);
			}
			Console.ReadKey();
		}
	}
}
