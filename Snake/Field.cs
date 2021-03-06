﻿using System;
using System.Collections.Generic;
namespace Snake
{
    class Field
    {
        /*0-пустая клетка(пусто на экране), #-стена*/
        private int X;
        private int Y;
        internal int Score {get;set;}
        internal int NowX { get; set; }
        internal int NowY { get; set; }
        private List<Char> Snake = new List<Char>();
        private char[,] FieldArray;
        private int[] ar = new int[1];
        private int[] FruitCoord = new int[2];
        private Random random = new Random();
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
                        FieldArray[i,i2] = ' ';
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
        public void InitFruit()
        {
            int x = random.Next(1, X - 2);
            int y = random.Next(1, Y - 2);
            if (FieldArray[x, y] == ' ')
            {
                FruitCoord[0] = x;
                FruitCoord[1] = y;
            }
            Console.SetCursorPosition(y*2, x);
            Console.Write('0');
        }
        public void InitSnake()
        {
            FieldArray[1, 1] = 'x';
            NowX = 1;
            NowY = 1;
            Score = 0;
        }
        public int Moving(string direction,int num,int head)
        {
            
            switch (direction)
            {
                case "left":
                    if (FieldArray[NowX, NowY - 1] != '#')
                    {
                        FieldArray[NowX, NowY] = ' ';
                        FieldArray[NowX, NowY - 1] = 'x';
                        NowY = NowY - 1;
                        drw.MoveDraw(NowX, NowY * 2, "left");
                    }
                    else return 1;
                    break;
                case "right":
                    if (FieldArray[NowX, NowY + 1] != '#')
                    {
                        FieldArray[NowX, NowY] = ' ';
                        FieldArray[NowX, NowY + 1] = 'x';
                        NowY = NowY + 1;
                        drw.MoveDraw(NowX, NowY*2,"right");
                    }
                    else return 1;
                    break;
                case "up":
                    if (FieldArray[NowX - 1, NowY] != '#')
                    {
                        FieldArray[NowX, NowY] = ' ';
                        FieldArray[NowX - 1, NowY] = 'x';
                        NowX = NowX - 1;
                        drw.MoveDraw(NowX, NowY * 2, "up");
                    }
                    else return 1;
                    break;
                case "down":
                    if (FieldArray[NowX + 1, NowY] != '#')
                    {
                        FieldArray[NowX, NowY] = ' ';
                        FieldArray[NowX + 1, NowY] = 'x';
                        NowX = NowX + 1;
                        drw.MoveDraw(NowX, NowY * 2, "down");
                    }
                    else return 1;
                    break;
                default:
                    break;
            }
            if (FruitCoord[0] == NowX && FruitCoord[1] == NowY)
                {
                    Score += 1;
                    InitFruit();
                }
            return 0;
        }

    }
}
