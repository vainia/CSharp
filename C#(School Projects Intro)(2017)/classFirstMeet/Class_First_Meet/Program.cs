using System;

namespace Class_First_Meet
{
	class A 
	{
		private int x;
		private int y;
		private int z;

		public A(int px, int py) 
		{
			x = px;
			y = py;
			z = px + py;
		}

		public A(int px, int py, int pz)
		{
			x = px;
			y = py;
			z = pz;
		}

		public A(int px)
		{
			x = px;
			y = px;
			z = px;
		}

		public int Value(int i) 
		{
			if (i == 1) return x;
			if (i == 2) return y;
			else return z;
		}
	}
	class MainClass
	{
		public static void Main(string[] args)
		{
			A pom = new A(1, 2);

			Console.Write("x=" + pom.Value(1));
			Console.Write("\ty=" + pom.Value(2));
			Console.WriteLine("\tz=" + pom.Value(3));

			A pom2 = new A(2, 4, 6);

			Console.Write("x=" + pom2.Value(1));
			Console.Write("\ty=" + pom2.Value(2));
			Console.WriteLine("\tz=" + pom2.Value(3));

			A pom3 = new A(3);

			Console.Write("x=" + pom3.Value(1));
			Console.Write("\ty=" + pom3.Value(2));
			Console.WriteLine("\tz=" + pom3.Value(3));

			Console.ReadKey();
		}
	}
}
