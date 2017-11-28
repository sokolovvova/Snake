using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(150,50);
            Console.CursorVisible = false;
            Console.WriteLine("Enter size of field:");
            Console.WriteLine("X(<=" + Convert.ToString(40) + "): ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y(<=" + Convert.ToString(70) + "): ");
            int y = Convert.ToInt32(Console.ReadLine());
            if(x>40 || y> 70){
                Console.WriteLine("Wrong Size... Exiting... Press any key ");
                Console.ReadKey();
                return;
            }
            Field field = new Field(x+2, y+2);
            x += 2;
            y += 2;
            Console.Clear();
            int GameState = 1;
            field.MakeArray();
            field.InitFruits(50);
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
                    GameState = 2;
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
                int state = field.Moving(Direction);
                Console.SetCursorPosition(17, x + 1);
                Console.Write("                                ");
                Console.SetCursorPosition(0,x+1);
                Console.Write("Head Coordinats: "+Convert.ToString(field.NowX) + " " + Convert.ToString(field.NowY));
                Console.SetCursorPosition(0, x + 3);
                Console.Write("Input: ");
                Console.SetCursorPosition(7, x + 3);
                if (state == 1)
                {
                    GameState = 3;
                    break;
                }
            }
            Console.SetCursorPosition(0, x + 4);
            switch (GameState)
            {
                case 1:
                    Console.WriteLine("WTF why is over???...  press any key");
                    break;
                case 2:
                    Console.WriteLine("Exiting...  press any key");
                    break;
                case 3:
                    Console.WriteLine("Game over! press any key");
                    break;
                default:
                    Console.WriteLine("Unexpected Condition. Exiting... press any key");
                    break;

            }
            Console.ReadKey();
        }
    }
}
