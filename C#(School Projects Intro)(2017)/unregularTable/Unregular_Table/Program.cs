using System;

namespace Unregular_Table
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int[][] tab;
			int r;
			Random los;
			los = new Random();

			//Console.Write("rozmiar r?=");
			//r = Convert.ToInt32(Console.ReadLine());
			r = los.Next(10, 21);
			tab = new int[r][];

			for (int i = 0; i < tab.Length; i++)
			{
				//Console.Write("rozmiar r?=");
				//r = Convert.ToInt32(Console.ReadLine());
				r = los.Next(6, 13);
				tab[i] = new int[r];
				for (int j = 0; j < r; ++j)
					tab[i][j] = los.Next(0,100);
			}

			////////////////nadpisy nad tablica/////////////
			int MaxL = 0;

			for (int i = 0; i < tab.Length; i++)
				if (MaxL < tab[i].Length) 
					MaxL = tab[i].Length;

			Console.Write("   ");
			for (int i = 0; i < MaxL; ++i)
				Console.Write("{0,3}.", i+1);
			
			Console.WriteLine();
			/////////////////////////////////////////////////

			for (int i = 0; i < tab.Length; i++)
			{
				Console.Write("{0,2}.", i + 1);              //////////////////////czesc kodu od napisow nad tablica////////////////////////
				for (int j = 0; j < tab[i].Length; ++j)
					Console.Write("[{0,2}]", tab[i][j]);
				Console.WriteLine();
			}

			int w = 0, max = 0, w2 = 0, min = 100;
			for (int i = 0; i < tab.Length; i++)
			{
				for (int j = 0; j < tab[i].Length; ++j)
				{
					if (max < tab[i][j])
					{
						max = tab[i][j];
						w = i;
					}
					if (min >= tab[i][j])
					{
						min = tab[i][j];
						w2 = i;
					}
				}
			}

			Console.WriteLine("\nmaximum={0} w wierszu {1}", max, w+1);
			Console.WriteLine("minimum={0} w wierszu {1}\n", min, w2 + 1);

			///////////////////////zamiana wierszy miejscami///////////////////////
			//int[] pom = tab[w];
			//tab[w] = tab[w2];
			//tab[w2] = pom;

			//for (int i = 0; i < tab.Length; i++)
			//{
			//	for (int j = 0; j < tab[i].Length; ++j)
			//		Console.Write("[{0,2}]", tab[i][j]);
			//	Console.WriteLine();
			//}
			///////////////////////////////////////////////////////////////////////

			Console.ReadKey();
		}
	}
}