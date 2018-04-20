using System;

namespace Two_Direction_Table
{
	class Two_Direction_Table
	{
		static void Main(string[] args)
		{
			int[,] tab;
			int r1, r2;
			//int zakres;
			Random los = new Random();

			//Console.Write("rozmiar r1 ?=");
			//r1 = Convert.ToInt32(Console.ReadLine());
			r1 = los.Next(10, 21);
			//Console.Write("rozmiar r2 ?=");
			//r2 = Convert.ToInt32(Console.ReadLine());
			r2 = los.Next(10, 21);
			tab = new int[r1, r2];
			//Console.Write("zakres ?=");
			//zakres = Convert.ToInt32(Console.ReadLine());

			//for (int i = 0; i < r1; i++)
			for (int i = 0; i < tab.GetLength(0); i++)
			{
				//for (int j = 0; j < r2; j++)
				for (int j = 0; j < tab.GetLength(1); j++)
				{
					tab[i, j] = i+r1*j;
					//tab[i, j] = los.Next(0, 100);
				}
			}

			for (int i = 0; i < r1; i++)
			{
				for (int j = 0; j < r2; j++)
				{
					Console.Write("[{0,2}]", tab[i, j]);
				}
				Console.WriteLine();
			}

			Console.Write("Rozmiar tablicy:");
			Console.Write(tab.GetLength(0) + "x");
			Console.WriteLine(tab.GetLength(1));
			Console.Write("Pojemnosc tablicy:");
			Console.WriteLine("{0}", tab.Length);

			Console.ReadKey();
		}
	}
}