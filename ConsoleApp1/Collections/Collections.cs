using ConsoleApp1;

namespace Collections
{
	internal class Collections
	{
		static void Main(string[] args)
		{
			//int[] num1 = new int[5];
			//num1[0] = 1;
			//num1[1] = 2;
			//num1[2] = 3;

			//Point[] point = new Point[3];
			//point[0] = new Point(1, 2, '*');
			//point[1] = new Point(3, 4, '@');
			//point[2] = new Point(5, 6, '(');

			//foreach (Point item in point)
			//{
			//	item.Draw();
			//}
			//Console.ReadLine();
			int[] x = new int[] {1,2,3} ;

			char[][] field = new char[3][];
			field[0] = new char[3];
			field[1] = new char[3];
			field[2] = new char[3];
			field[0][0] = 'a';
			field[2][2] = 'b';

			for (int i = 0; i < field.Length; i++)
			{
				for (int j = 0; j < field[i].Length; j++)
				{
					Console.Write(field[i][j]);

				}
				Console.WriteLine();
			}

			Console.ReadLine();


		}
	}
}
