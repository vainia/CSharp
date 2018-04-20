using System;

namespace Functions_First_Meet
{
	class MainClass
	{
		static void zamiana(ref int x, ref int y)
		{
			int pom;
			pom = x;
			x = y;
			y = pom;
		}

		static void Main(string[] args)
		{
			int x, y;

			x = 0;
			y = 125;

			Console.WriteLine("x={0}\ty={1}", x, y);

			zamiana(ref x, ref y);

			Console.WriteLine("x={0}\ty={1}", x, y);

			Console.ReadKey();
		}
	}
}
