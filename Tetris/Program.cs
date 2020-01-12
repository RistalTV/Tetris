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
            area.PrintMap();

            
        }
    }
}
