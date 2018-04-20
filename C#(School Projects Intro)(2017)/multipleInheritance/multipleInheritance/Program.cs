using System;

namespace multipleInheritance
{
	class A
	{
		private int x;
		protected A(int px = 1)
		{
			x = px;
			Console.WriteLine("Konstruktor A");
		}
		~A()
		{
			Console.WriteLine("Destruktor A");
		}

		protected int ax
		{
			set
			{
				x = value;
			}
			get
			{
				return x;
			}
		}
	}

	class B : A
	{
		private int y;
		public B(int kx = 1, int ky = 2) : base(kx)
		{
			y = ky;
			Console.WriteLine("Konstruktor B");
		}
		~B()
		{
			Console.WriteLine("Destruktor B");
		}

		public int bx
		{
			set
			{
				ax = value;
			}
			get
			{
				return ax;
			}
		}
		public int by
		{
			set
			{
				y = value;
			}
			get
			{
				return y;
			}
		}
		public void druk()
		{
			Console.Write("x={0}\t", ax);
			Console.WriteLine("y={0}", y);
		}
	}

	class C : B
	{
		public C(int px, int py)
			: base(px, py)
		{
			Console.WriteLine("Konstruktor C");
		}
		~C()
		{
			Console.WriteLine("Destruktor C");
		}
	} 

	class MainClass
	{
		static void Main(string[] args)
		{
			C x1 = new C(3, 5);

			x1.druk();

			x1.bx = 12;
			x1.by = -17;

			x1.druk();

			Console.ReadKey();
		}
	}
}
