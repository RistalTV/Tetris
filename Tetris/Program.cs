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

            area.AddBlock(4, 4, 1);
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(300);
                area.Lift();
                area.PrintMap();
            }

            

            
        }
    }
}
