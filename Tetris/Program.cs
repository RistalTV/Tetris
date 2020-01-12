using System;
using System.Threading;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.Write(rnd.Next(0,10));
            
        }
    }
}
