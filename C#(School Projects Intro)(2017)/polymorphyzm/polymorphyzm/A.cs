using System;
namespace polymorphyzm
{
	public class A
	{
		private int x;
		public A(int px = 1)
		{
			x = px;
		}

		public virtual void druk()
		{
			Console.WriteLine("A.x={0}", x);
		}

		public virtual void zamiana(int own)
		{
			x = own;
			Console.WriteLine("po zamianie A.x={0}", x);
		}

		public virtual A copy()
		{
			A temp = new A(this.x);
			return temp;
		}

	}
}
