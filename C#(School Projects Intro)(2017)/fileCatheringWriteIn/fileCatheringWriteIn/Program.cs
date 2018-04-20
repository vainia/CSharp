using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fileCatheringWriteIn
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string sciezka = "/Users/vania/Projects/txt/T_0006.txt";
			FileStream plik;
			StreamWriter p;

			try
			{
				plik = new FileStream(sciezka, FileMode.CreateNew);
			}

			catch (FileNotFoundException)
			{
				Console.WriteLine("Brak pliku: {0}", sciezka);
				Console.ReadKey();
				return;
			}

			p = new StreamWriter(plik);

			for (int i = 0; i < 20; ++i)
				p.WriteLine(i.ToString());

			p.Close();
			plik.Close();

			Console.WriteLine("\n\n");
			Console.ReadKey();
		}
	}
}
