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
        private static Timer aTimer;
        static void Main(string[] args)
        {
            Console.WriteLine("test");
            Field field = new Field(15, 10);
            field.MakeArray();
            field.PrintArray();
            field.InitSnake();
            field.PrintArray();
            while (true)
            {
                string Direction="down";
                int key = Convert.ToInt32(Console.ReadKey().Key);
                if (key == 81) break;
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

                }
                field.Moving(Direction);
                Console.Clear();
                field.PrintArray();

            }
            Console.ReadKey();
        }
    }
}
