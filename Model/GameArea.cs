using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{


    public class GameArea
    {
        int height;//высота игрового поля
        int width;//ширина игрового поля
        int[,] map;//шаблон матрицы поля

        char Empty { set; get; } = '0';
        char Block { set; get; } = '1';

        public GameArea(int width, int height)
        {
            this.width = width;//инициализация ширины поля
            this.height = height;//инициализация высоты поля
            map = new int[width, height];//инициализация матрицы игрового поля
            ResetMap();
        }

        public void ResetMap()//метод очистки матрицы игрового поля(запись нулей)
        {
            for (int x = 0; x  < width; x ++)//перебор всех элементов матрицы
            {
                for (int y = 0; y < height; y++)
                {
                    setPos(x, y, 0);//запись нулей в каждую ячейку матрицы
                }
            }
        }

        public void PrintMap()
        {
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    switch (map[x, y])
                    {
                        //легенда обозначений карты
                        case 0: Console.Write(Empty); break;
                        case 1: Console.Write(Block); break;
                    }
                }
                Console.WriteLine();
            }
        }

        public void setPos(int x, int y, int value)
        {
            map[x, y] = value;
        }
        public int getPos(int x, int y)
        {
            return map[x, y];
        }


    }
}
