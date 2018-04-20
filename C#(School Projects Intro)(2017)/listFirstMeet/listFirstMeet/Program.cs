using System;

namespace listFirstMeet
{
	class lista
	{
		public lista next;
		public int data;

		public lista(int pdata)
		{
			data = pdata;
			next = null;
		}
	}

	class MainClass
	{
		static void Main(string[] args)
		{
			//lista pom = new lista(1); //pom data(1) next()
			//lista p1; 
			//p1 = pom; //p1 data(1) next()

			lista p1 = new lista(1); //p1 data(1) next() 
			lista pom;
			pom = p1; //pom data(1) next()

			for (int i = 0; i < 10; i++)
			{
				p1.next = new lista(p1.data + 1); //p1 data(1) next(data(2) next()) //p1 data(2) next(data(3) next()) ...
				p1 = p1.next; //p1 data(2) next() //p1 data(3) next() ...
			}
			p1 = pom;

			while (p1!=null)
			{
				Console.WriteLine(p1.data);
				p1 = p1.next;
			}
			Console.ReadKey();
		}
	}
}
