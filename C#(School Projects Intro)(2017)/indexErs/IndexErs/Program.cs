using System;


namespace IndexErs
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

		public void druk()
		{
			Console.Write("x={0}\t", x);
			Console.WriteLine("y={0}", y);
		}

		public int this[int i]
		{
			get
			{
				if (i == 1) return x; else return y;
			}
			set
			{
				if (i == 1) x = value; else y = value;
			}
		}
	}


	class MainClass
	{
		public static void Main(string[] args)
		{
			A x = new A(1, 2);

			x.druk();

			x[1] = 17;
			x[2] = 58;

			x.druk();

			Console.Write("x[1]={0}\t", x[1]);
			Console.WriteLine("x[2]={0}", x[2]);

			Console.ReadKey();
		}
	}
}