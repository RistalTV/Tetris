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
            GameArea area = new GameArea(8,10);
            area.setPos(1, 1, 1);
            area.setPos(2, 2, 1);
            area.setPos(3, 3, 1);
            area.PrintMap();

            
        }
    }
}
