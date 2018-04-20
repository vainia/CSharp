using System;

namespace FIRST_PROJECT_CSHARP
{
	class Program
	{

		public static int wpis()
		{
			return Convert.ToInt32(Console.ReadLine());
		}

		public static void Main(string[] args)
		{
			int[] tab;
			int r;
			int zakres = 10;



			Random pom = new Random();
			Console.Write("rozmiar r?=");
			r = wpis();

			if (r < 1)
				r = 1;

			Console.Write("zakres ?=");
			zakres = wpis();

			if (zakres < 1)
				zakres = 2;

			tab = new int[r];

			for (int i = 0; i < r; i++)
				tab[i] = pom.Next(zakres);

			for (int i = 0; i < tab.Length; i++)
				Console.WriteLine("t[{0,3}]={1,3}", i, tab[i]);

			Console.ReadKey();
		}
	}
}
