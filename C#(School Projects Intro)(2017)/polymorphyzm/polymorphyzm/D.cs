using System;
namespace polymorphyzm
{
	public class D : C
	{
		private int x;
		private int y;
		public D(int kx = 1, int ky = 2) : base(kx+ky)
		{
			x = kx;
			y = ky;
		}

		public override void druk()
		{
			Console.Write("D.x={0}, ", x);
			Console.Write("D.y={0}, ", y);
			base.druk();
		}

		public override void zamiana(int own)
		{
			x = own;
			y = own * 2;
			Console.WriteLine("po zamianie D.x={0}, ", x);
			Console.WriteLine("po zamianie D.y={0}", y);
			base.zamiana(own * 3);
		}

		public override A copy()
		{
			D temp = new D(this.x, this.y);
			return temp;
		}

	}
}
