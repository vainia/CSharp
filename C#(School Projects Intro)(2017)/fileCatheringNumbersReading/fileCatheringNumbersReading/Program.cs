using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fileCatheringNumbersReading
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string sciezka = "/Users/vania/Projects/txt/T_0002.txt";
			FileStream plik;
			StreamReader p;
			string x;
			int suma = 0;

			try
			{
				plik = new FileStream(sciezka, FileMode.Open);
			}

			catch (FileNotFoundException)
			{
				Console.WriteLine("Brak pliku: {0}", sciezka);
				Console.ReadKey();
				return;
			}

			p = new StreamReader(plik);

			x = p.ReadLine();

			while (x != null)
			{
				suma += Convert.ToInt32(x);
				Console.WriteLine(x);
				x = p.ReadLine();
			}
			p.Close();
			plik.Close();

			Console.WriteLine("\n\nsuma={0}\n",suma);
			Console.ReadKey();
		}
	}
}
