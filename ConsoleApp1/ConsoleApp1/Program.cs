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

			Point p1 = new Point();
			p1.x = 2;
			p1.y = 3;
			p1.c = '*';
			p1.Draw();

			Point p2 = new Point();
			p2.x = 3;
			p2.y = 4;
			p2.c = '#';
			p2.Draw();

			Console.ReadLine();
		}
	}
}
