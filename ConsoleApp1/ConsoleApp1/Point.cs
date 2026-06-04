using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
  class Point
  {
    public int x, y;
    public char c;

     public void Draw()
    {
      Console.SetCursorPosition(x, y);
      Console.WriteLine(c);
    }
  }
}
