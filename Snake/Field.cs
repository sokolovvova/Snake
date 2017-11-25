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
        private int x;
        private int y;
        private int NowX;
        private int NowY;
        private char[,] FieldArray;  
        public Field(int x,int y)
        {
            this.x = x;
            this.y = y;
        }

        public void MakeArray() //Создает массив состояния поля
        {
            FieldArray = new char[x, y];
            for (int i = 0; i < x; i++)
            {
                for(int i2 = 0; i2 < y; i2++)
                {
                    if(i==0 || i2 == 0 || (i==x-1)||(i2==y-1))
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
            for (int i = 0; i < x; i++)
            {
                for (int i2 = 0; i2 < y; i2++)
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
                    }
                    break;
                case "right":
                    if (FieldArray[NowX, NowY + 1] != '#')
                    {
                        FieldArray[NowX, NowY] = '0';
                        FieldArray[NowX, NowY + 1] = 'x';
                        NowY = NowY + 1;
                    }
                    break;
                case "up":
                    if (FieldArray[NowX - 1, NowY] != '#')
                    {
                        FieldArray[NowX, NowY] = '0';
                        FieldArray[NowX - 1, NowY] = 'x';
                        NowX = NowX - 1;
                    }
                    break;
                case "down":
                    if (FieldArray[NowX + 1, NowY] != '#')
                    {
                        FieldArray[NowX, NowY] = '0';
                        FieldArray[NowX + 1, NowY] = 'x';
                        NowX = NowX + 1;
                    }
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }


        }

    }
}
