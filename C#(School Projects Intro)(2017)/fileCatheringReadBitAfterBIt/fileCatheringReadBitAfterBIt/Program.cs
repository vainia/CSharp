using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fileCatheringReadBitAfterBIt
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string nazwa = "/Users/vania/Projects/txt/T_0001.txt";
			FileStream plik;
			int x;

			try
			{
				plik = new FileStream(nazwa, FileMode.Open);
			}

			catch (FileNotFoundException)
			{
				Console.WriteLine("Brak pliku: {0}", nazwa);
				Console.ReadKey();
				return;
			}

			x = plik.ReadByte();

			while (x > 0)
			{
				Console.Write((char)x);
				x = plik.ReadByte();
			}
			plik.Close();

			Console.WriteLine("\n\n");
			Console.ReadKey();
		}
	}
}
