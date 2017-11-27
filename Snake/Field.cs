using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Field
    {
        /*0-пустая клетка(пусто на экране), #-стена*/
        private int X;
        private int Y;
        internal int NowX { get; set; }
        internal int NowY { get; set; }
        private char[,] FieldArray;
        private ConDrawing drw = new ConDrawing();
        public Field(int x,int y)
        {
            this.X = x;
            this.Y = y;
        }
        public void MakeArray() //Создает массив состояния поля
        {
            FieldArray = new char[X, Y];
            for (int i = 0; i < X; i++)
            {
                for(int i2 = 0; i2 < Y; i2++)
                {
                    if(i==0 || i2 == 0 || (i==X-1)||(i2==Y-1))
                    {
                        FieldArray[i,i2] = '#';
                    }
                    else
                    {
                        FieldArray[i,i2] = '0';
                    }
                }
            }
        }
        public void PrintArray() //печатает массив состояния поля
        {
            for (int i = 0; i < X; i++)
            {
                for (int i2 = 0; i2 < Y; i2++)
                {
                    Console.Write(Convert.ToString(FieldArray[i, i2])+" ");
                }
                Console.WriteLine();
            }
        }
        public void InitSnake()
        {
            FieldArray[1, 1] = 'x';
            NowX = 1;
            NowY = 1;
        }
        public void Moving(string direction)
        {
            switch (direction)
            {
                case "left":
                    if (FieldArray[NowX, NowY - 1] != '#')
                    {
                        FieldArray[NowX, NowY] = '0';
                        FieldArray[NowX, NowY - 1] = 'x';
                        NowY = NowY - 1;
                        drw.MoveDraw(NowX, NowY * 2, "left");
                    }
                    break;
                case "right":
                    if (FieldArray[NowX, NowY + 1] != '#')
                    {
                        FieldArray[NowX, NowY] = '0';
                        FieldArray[NowX, NowY + 1] = 'x';
                        NowY = NowY + 1;
                        drw.MoveDraw(NowX, NowY*2,"right");
                    }
                    break;
                case "up":
                    if (FieldArray[NowX - 1, NowY] != '#')
                    {
                        FieldArray[NowX, NowY] = '0';
                        FieldArray[NowX - 1, NowY] = 'x';
                        NowX = NowX - 1;
                        drw.MoveDraw(NowX, NowY * 2, "up");
                    }
                    break;
                case "down":
                    if (FieldArray[NowX + 1, NowY] != '#')
                    {
                        FieldArray[NowX, NowY] = '0';
                        FieldArray[NowX + 1, NowY] = 'x';
                        NowX = NowX + 1;
                        drw.MoveDraw(NowX, NowY * 2, "down");
                    }
                    break;
                default:
                    break;
            }
        }

    }
}
