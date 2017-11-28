using System;
using System.Collections.Generic;

namespace Snake
{
    class ConDrawing
    {
        public void MoveDraw(int y,int x,string dir)
        {
            switch (dir)
            {
                case "left":
                    Console.SetCursorPosition(x, y);
                    Console.Write("x");
                    Console.SetCursorPosition(x + 2, y);
                    Console.Write("");
                    break;
                case "right":
                    Console.SetCursorPosition(x, y);
                    Console.Write("x");
                    Console.SetCursorPosition(x - 2, y);
                    Console.Write(" ");
                    break;
                case "up":
                    Console.SetCursorPosition(x, y);
                    Console.Write("x");
                    Console.SetCursorPosition(x , y + 1);
                    Console.Write(" ");
                    break;
                case "down":
                    Console.SetCursorPosition(x, y);
                    Console.Write("x");
                    Console.SetCursorPosition(x , y - 1);
                    Console.Write(" ");
                    break;



            }
        }
    }
}
