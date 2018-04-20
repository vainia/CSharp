using System;

namespace exceptions
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int x, y, z;
			int[] t = { '1', '2' };

			x = 5;
			y = 0;

			try
			{
				z = x / y;
			}
			catch (DivideByZeroException e)
			{
				Console.Write("Dzielenie przez 0\n\n");
				Console.WriteLine(e.ToString()+"\n\n");
			}
			//catch (SystemException e)
			//{
			//	Console.WriteLine("ERROR\n\n"+e.ToString());
			//}

			try
			{
				t[4] = 7;
			}
			//catch (DivideByZeroException e)
			//{
			//	Console.Write("Dzielenie przez 0\n\n");
			//	Console.WriteLine(e.ToString());
			//}
			catch (IndexOutOfRangeException e)
			{
				Console.Write("Poza zakresem\n\n");
				Console.WriteLine(e.ToString());
			}
			//catch (SystemException e)
			//{
			//	Console.WriteLine("ERROR\n\n" + e.ToString());
			//}

			Console.ReadKey();
		}
	}
}
