using System;
namespace polymorphyzm
{
	public class C : A
	{
		private int x;
		public C(int kx = 1) : base(kx)
		{
			x = kx;
		}
	
		public override void druk()
		{
			Console.Write("C.x={0}, ", x);
			base.druk();
		}

		public override void zamiana(int own)
		{
			x = own;
			Console.WriteLine("po zamianie C.x={0}", x);
			base.zamiana(own * 2);
		}

		public override A copy()
		{
			C temp = new C(this.x);
			return temp;
		}

	}
}

