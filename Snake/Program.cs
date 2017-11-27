using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.WriteLine("Enter size of field:");
            Console.WriteLine("X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Field field = new Field(x+2, y+2);
            x += 2;
            y += 2;
            Console.Clear();
            field.MakeArray();
            field.InitSnake();
            field.PrintArray();
            Console.SetCursorPosition(0, x);
            Console.WriteLine("Field Size: "+Convert.ToString(x-2)+"x"+ Convert.ToString(y-2)+"("+ Convert.ToString(x)+"x"+ Convert.ToString(y)+")");
            Console.SetCursorPosition(0, x + 2);
            Console.WriteLine("Help: q-quite");
            while (true)
            {
                string Direction="";
                int key = Convert.ToInt32(Console.ReadKey().Key);
                if (key == 81)
                {
                    Console.SetCursorPosition(0, x + 4);
                    Console.WriteLine("Exiting...  press any key");
                    break;
                }
                switch (key)
                {
                    case 38:
                        Direction = "up";
                        break;
                    case 39:
                        Direction = "right";
                        break;
                    case 40:
                        Direction = "down";
                        break;
                    case 37:
                        Direction = "left";
                        break;
                    default:
                        Console.SetCursorPosition(0, x + 4);
                        Console.WriteLine("Error input");
                        break;

                }
                field.Moving(Direction);
                /*Console.Clear();*/
                /*field.PrintArray();*/
                Console.SetCursorPosition(17, x + 1);
                Console.Write("                                ");
                Console.SetCursorPosition(0,x+1);
                Console.Write("Head Coordinats: "+Convert.ToString(field.NowX) + " " + Convert.ToString(field.NowY));
                Console.SetCursorPosition(0, x + 3);
                Console.Write("Input: ");
                Console.SetCursorPosition(7, x + 3);
            }
            Console.ReadKey();
        }
    }
}
