using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
          
            HorizontalLine Upline = new HorizontalLine(0, 118, 0, '+');
            HorizontalLine Downline = new HorizontalLine(0, 118, 29, '+');
            VerticalLine Leftline = new VerticalLine(0, 29, 0, '+');
            VerticalLine Rightline = new VerticalLine(0, 29, 118, '+');


            Upline.Drow();
            Downline.Drow();
            Leftline.Drow();
            Rightline.Drow();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT, false);
            snake.Drow();
            

            while(true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                    if(snake.exitflag == true)
                    {
                        break;
                    }
                }
                Thread.Sleep(100);
                snake.Move();
            }
        }

        

    }
}
