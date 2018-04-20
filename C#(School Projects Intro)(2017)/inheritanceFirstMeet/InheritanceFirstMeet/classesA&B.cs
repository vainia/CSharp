using System;
namespace InheritanceFirstMeet
{
	class A
	{
		private int x;
		private int y;
		protected A(int px = 1, int py = 1)
		{
			x = px;
			y = py;
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

		protected int ay
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
	}
	class B : A
	{
		private int x;
		public B(int kx = 1, int ky = 2, int bxx=3) : base(kx,ky)
		{
			x = bxx;
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
				ay = value;
			}
			get
			{
				return ay;
			}
		}
		public int bxx
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
		public void druk()
		{
			Console.Write("Ax={0}\t", ax);
			Console.Write("Ay={0}\t", ay);
			Console.WriteLine("Bx={0}", bxx);

		}
	}
	class C : A
	{
		private int x;
		private int y;
		private int z;
		public C(int kx = 1, int ky = 2, int kcx = 3, int kcy = 4, int kcz = 5) : base(kx, ky)
		{
			x = kcx;
			y = kcy;
			z = kcz;
		}

		public int cx
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
		public int cy
		{
			set
			{
				ay = value;
			}
			get
			{
				return ay;
			}
		}
		public int cxx
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
		public int cyy
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
		public int czz
		{
			set
			{
				z = value;
			}
			get
			{
				return z;
			}
		}
		public void druk()
		{
			Console.Write("Ax={0}\t", cx);
			Console.Write("Ay={0}\t", cy);
			Console.Write("Cx={0}\t", cxx);
			Console.Write("Cy={0}\t", cyy);
			Console.WriteLine("Cz={0}", czz);

		}
	}
}