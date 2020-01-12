using System;
using System.Threading;
using Model;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            GameArea area = new GameArea(9,12);
            //area.SetPos(0, 0, 1);
            //area.SetPos(1, 1, 1);
            //area.SetPos(2, 2, 1);

            for (int y = 0; y < 12-1; y++)
                for (int x = 0; x < 9; x++)
                {
                    area.SetPos(x, y, 5);
                }
            //area.Lift();
            area.PrintMap();

            
        }
    }
}
