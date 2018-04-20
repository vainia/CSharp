using System;


namespace AccessoryGetNSet
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

		public int px
		{
			get 
			{
				return x;
			}
			set
			{
				x = value;
			}
		}

		public int py
		{
			get
			{
				return y;
			}
			set
			{
				y = value;
			}
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

			Console.WriteLine("Obiekt x1:");
			x1.druk();

			x1.px = 7;
			x1.py = 12;

			Console.WriteLine("\nPo podstawieniu");
			Console.WriteLine("Obiekt x1:");
			x1.druk();

			Console.WriteLine("Obiekt x1:");
			Console.Write("x1.x={0}\t",x1.px);
			Console.WriteLine("x1.y={0}\t", x1.py);

			Console.ReadKey();
		}
	}
}