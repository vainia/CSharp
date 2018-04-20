using System;

namespace AbstractDataType
{
	abstract class A
	{
		public int x;
		public A(int px)
		{
			x = px;
		}
		public abstract void druk();
	}

	class B : A
	{
		public B(int px) : base(px)
		{
			Console.WriteLine("Konstruktor B");
		}
		public override void druk()
		{
			Console.WriteLine("x=" + x);
		}
	}

	class MainClass
	{
		static void Main(string[] args)
		{
			B pom = new B(15);
			pom.druk();
			pom.x = 12;
			pom.druk();

			Console.ReadKey();
		}
	}
}
