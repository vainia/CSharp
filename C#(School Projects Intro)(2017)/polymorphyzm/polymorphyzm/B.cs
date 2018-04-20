using System;
namespace polymorphyzm
{
	public class B : A
	{
		private int x;
		private int y;
		public B(int kx = 1, int ky = 2) : base(kx+ky)
		{
			x = kx;
			y = ky;
		}
	
		public override void druk()
		{
			Console.Write("B.x={0}, ", x);
			Console.Write("B.y={0}, ", y);
			base.druk();
		}

		public override void zamiana(int own)
		{
			x = own;
			y = own*2;
			Console.WriteLine("po zamianie B.x={0}", x);
			Console.WriteLine("po zamianie B.y={0}", y);
			base.zamiana(own * 3);
		}

		public override A copy()
		{
			B temp = new B(this.x, this.y);
			return temp;
		}

	}
}
