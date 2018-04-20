using System;
using System.Collections; //pilne dla list wbudowanych!

namespace listIncludedInLanguage2
{
	class A
	{
		public override string ToString()
		{
			return ("A\n");
		}
	}
	class B:A
	{
		public override string ToString()
		{
			return ("B\n");
		}
	}
	class C:A
	{
		public override string ToString()
		{
			return ("C\n");
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			ArrayList lista = new ArrayList();

			A px;

			for (int i = 0; i < 10; ++i)
			{
				if (i % 2 == 0)
					px = new B();
				else
					px = new C();
				lista.Add(px);
			}

			for (int i = 0; i < lista.Count; ++i)
			{
				Console.WriteLine(lista[i]);
			}
			Console.ReadKey();
		}
	}
}