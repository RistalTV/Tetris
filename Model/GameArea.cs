using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    public class Point
    {


        public int X 
        { 
            set 
            {
                X = value;
            } 

            get 
            {
                return X;
            } 
        }
        public int Y
        {
            set
            {
                Y = value;
            }

            get
            {
                return Y;
            }
        }

    }
    public class Block
    {
        public Point SpawnPoint = new Point();
        public Point a;
        public Point b;
        public Point c;
        public Point e;

        int type = 1; //1 - cross 2 - snake 3 - hook 4 - line 5 - box 
        public Block(int x, int y, int type)
        {
            SpawnPoint.X = x;
            SpawnPoint.Y = y;
            switch (type)
            {
                case 1://cross
                    a.X = SpawnPoint.X;
                    a.Y = SpawnPoint.Y;

                    b.X = SpawnPoint.X - 1;
                    b.Y = SpawnPoint.Y + 1;

                    c.X = SpawnPoint.X;
                    c.Y = SpawnPoint.Y + 1;

                    e.X = SpawnPoint.X + 1 ;
                    e.Y = SpawnPoint.Y + 1;

                    break;
                case 2:

                    break;
                case 3:
                    
                    break;
                case 4:
                    break;
                default:
                    a.X = SpawnPoint.X;
                    a.Y = SpawnPoint.Y;
                    break;
            }
        }
        

    };

    public class GameArea
    {
        int height;//высота игрового поля
        int width;//ширина игрового поля
        int[,] map;//шаблон матрицы поля

        

        char EmptyTile { set; get; } = '0';
        char BlockTile { set; get; } = '1';



        public void AddBlock(int spawnX, int spawnY, int typeBLock)
        {
            Block block = new Block(spawnX, spawnY, typeBLock);
            SetPos(block.a.X,block.a.Y,1);
            SetPos(block.b.X, block.b.Y, 1);
            SetPos(block.c.X, block.c.Y, 1);
            SetPos(block.e.X, block.e.Y, 1);
        }
        public int GetSizeX()
        {
            return width;
        }
        public int GetSizeY()
        {
            return height;
        }

        public GameArea(int width, int height)
        {
            this.width = width;//инициализация ширины поля
            this.height = height;//инициализация высоты поля
            map = new int[width, height];//инициализация матрицы игрового поля
            ResetMap();
        }

        public void ResetMap()//метод очистки матрицы игрового поля(запись нулей)
        {
            for (int y = 0; y  < height; y ++)//перебор всех элементов матрицы
            {
                for (int x = 0; x < width; x++)
                {
                    SetPos(x, y, 0);//запись нулей в каждую ячейку матрицы
                }
            }
        }

        public void PrintMap()
        {
            Console.Clear();
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    switch (GetPos(x,y))
                    {
                        //легенда обозначений карты
                        case 0: Console.Write(EmptyTile); break;
                        case 1: Console.Write(BlockTile); break;
                        default: Console.Write(GetPos(x, y)); break;
                    }
                }
                Console.WriteLine();
            }
        }

        public void SetPos(int x, int y, int value)
        {
            map[x, y] = value;
        }
        public int GetPos(int x, int y)
        {
            return map[x, y];
        }

        public void Lift()
        {
            for (int y = height-1; y > 0 ; y--)//перебор всех элементов матрицы
            {
                for (int x = 0; x < width; x++)
                {
                    if (GetPos(x, y) == 0)
                    {
                        SetPos(x, y, GetPos(x, y - 1));
                        SetPos(x, y - 1, 0);
                    }
                    //Console.Write("y: " + y + " x: " + x);
                }
                //Console.WriteLine();
            }
            //for(int i = 0; i < width; i++) SetPos(i, 0, 0);
        }
    }
}
