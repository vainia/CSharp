using System;


namespace CopyOfObjectProgram1
{
	class A
	{
		private int x;
		private int y;

		public A(int px = 0, int py = 0)
		{
			x = px;
			y = py;
		}

		public int Value(int i)
		{
			if (i == 1) return x;
			return y;
		}

		public void Value(int i, int p)
		{
			if (i == 1) x = p; else y = p;
		}

		public void druk()
		{
			Console.Write("x={0}\t", x);
			Console.WriteLine("y={0}", y);
		}
	}
	class MainClass
	{
		public static void Main(string[] args)
		{
			A x1 = new A(1, 1);
			A x2 = new A(2, 3);

			Console.WriteLine("Obiekt x1:");
			x1.druk();
			Console.WriteLine("Obiekt x2:");
			x2.druk();

			x1 = x2;

			Console.WriteLine("\nPo podstawieniu");
			Console.WriteLine("Obiekt x1:");
			x1.druk();
			Console.WriteLine("Obiekt x2:");
			x2.druk();

			x1.Value(1, 12);

			Console.WriteLine("Po zamianie x1");
			Console.WriteLine("Obiekt x1:");
			x1.druk();
			Console.WriteLine("Obiekt x2:");
			x2.druk();

			Console.ReadKey();
		}
	}
}