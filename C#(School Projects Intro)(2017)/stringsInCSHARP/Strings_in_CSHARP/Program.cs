using System;

namespace Strings_in_CSHARP
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			char[] napis1 = { 'a', 'l', 'a' };
			string napis2 = new string(napis1);
			string napis3 = "ala ma kota";
			string napis4 = @"ala ma kota kot ma mysz mysz ma ser";
			int x = 20;

			string liczba = x.ToString();


			Console.WriteLine("napis2: " + napis2);
			Console.WriteLine("napis3: " + napis3);
			Console.WriteLine("napis4: " + napis4);

			Console.Write("pierwszy ma: ");
			Console.WriteLine(napis4.IndexOf("ma"));
			Console.Write("ostatni ma: ");
			Console.WriteLine(napis4.LastIndexOf("ma"));
			Console.WriteLine();

			Console.WriteLine("int x={0}", x);
			Console.WriteLine("string liczba={0}", liczba);

			Console.ReadKey();
		}
	}
}
