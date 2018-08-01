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


            Upline.Draw();
            Downline.Draw();
            Leftline.Draw();
            Rightline.Draw();


            VerticalLine v1 = new VerticalLine(10, 15, 5, '@');
            Draw(v1);

            Point p = new Point(4, 5, '*');
            Figure fSnake = new Snake(p, 4, Direction.RIGHT, false);
            Draw(fSnake);
            Snake snake = (Snake)fSnake;

            HorizontalLine h1 = new HorizontalLine(5, 10, 6, '&');

            List<Figure> figures = new List<Figure>();
            figures.Add(fSnake);
            figures.Add(v1);
            figures.Add(h1);

            foreach(var f in figures)
            {
                f.Draw();
            }

            /*
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT, false);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(117, 28, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

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

                if(snake.Eat(food))
                    {
                    food = foodCreator.CreateFood();
                    food.Draw();
                    }
                Thread.Sleep(100);
                snake.Move();

            }
            */

            Console.ReadLine();
        }


        static void Draw(Figure figure)
        {
            figure.Draw();
        }

    }
}
