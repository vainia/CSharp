using System;

namespace InheritanceFirstMeet
{
	class MainClass
	{
		static void Main(string[] args)
		{
			B x1 = new B(3, 5, 7);
			C x2 = new C(3, 5, 7, 5, 1);

			x1.druk();
			Console.WriteLine("Largest in class B is "+myMax2(x1.bx, x1.by, x1.bxx));
			x1.bx = 12;
			x1.by = -17;
			x1.druk();
			Console.WriteLine("Largest in class B is " + myMax2(x1.bx, x1.by, x1.bxx));
			x2.druk();
			Console.WriteLine("Largest in class C is " + myMax4(x2.cx, x2.cy, x2.cxx, x2.cyy, x2.czz));


			Console.ReadKey();
		}
		////////////////////////////////////////////////////////////////////////////////////////////////
		static int myMax1(int a, int b)																 ///
		{												 										   	 ///
			return (a > b) ? a : b;																	 ///
		}																							 ///
		static int myMax2(int a, int b, int c)														 ///
		{																							 ///
			return (c > myMax1(a, b)) ? c : myMax1(a, b);											 ///
		}												 											 ///
		static int myMax3(int a, int b, int c, int d)    											 ///
		{                                                											 ///
			return (d > myMax2(a, b, c)) ? d : myMax2(a, b, c);										 ///
		} 																							 ///
		static int myMax4(int a, int b, int c, int d, int e)                                         ///
		{                                                                                            ///
			return (e > myMax3(a, b, c, d)) ? e : myMax3(a, b, c, d);							     ///
		}																						     ///
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
}