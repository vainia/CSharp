using System;

namespace polymorphyzm
{
	class MainClass
	{
		static void Main(string[] args)
		{
			table tab = new table(10);
			tab.myPrint();

			Console.WriteLine();

			table tabCopy = tab.copy();
			tabCopy.myPrint();

			Console.WriteLine();

			tabCopy.zamiana();

			Console.WriteLine();

			tabCopy.myPrint();

			Console.WriteLine("\nOryginal\n");

			tab.myPrint();

			Console.ReadKey();
		}
	}
}