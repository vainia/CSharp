using System;

namespace One_And_Two_Direction_Table
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int[] tab1 = { 2, 3, 6, 7, 2, 1, 12, -3 };
			int[,] tab2 = { { 2, 3 }, { 4, 8 }, { 1, -5 } };

			Console.Write("Rozmiar tab1:");
			Console.WriteLine(tab1.Length);
			Console.Write("Wymiary tab2:");
			Console.Write(tab2.GetLength(0) + "x");
			Console.WriteLine(tab2.GetLength(1));

			foreach (var pom in tab1)
			{
				Console.Write("[{0,2}]", pom);
			}

			Console.WriteLine("\n\n");

			foreach (var pom in tab2)
			{
				Console.WriteLine("[{0,2}]", pom);
			}

			Console.ReadKey();
		}
	}
}
