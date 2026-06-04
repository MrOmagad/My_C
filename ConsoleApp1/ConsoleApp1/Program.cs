using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp1
{	
	class Program
	{
		static void Main(string[] args)
		{
			Console.SetWindowSize(40, 30);
			Console.SetBufferSize(40, 30);

			int x1 = 2;
			int y1 = 3;
			char c1 = '*';

			Point p1 = new Point(2, 3 , '@');
			p1.Draw();

			Console.ReadLine();
		}
	}
}
