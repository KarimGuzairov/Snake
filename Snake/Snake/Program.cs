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
            Point p = new Point(4, 5, '*'); // задание хвоста змейки
            Snake snake = new Snake(p, 4, Direction.RIGHT, false); //Создание объекта змейка
            snake.Draw(); // Рисование объекта змейка

            FoodCreator foodCreator = new FoodCreator(117, 28, '$'); //Задание границ создания "еды" и значка для "еды"
            Point food = foodCreator.CreateFood(); // Создание точки food
            food.Draw(); //Рисование точки food

            Walls walls = new Walls(117, 28); //Создание объекта walls
            walls.Draw(); // рисование препятствий и рамок игрового поля

            while(true) //бесконечный цикл, в котором происходит движение змейки, акты питания и проверка на столкновение с препятствиями
            {
                if (walls.IsHit (snake) || snake.IsHitTail()) // значок || означает "ИЛИ".
                {
                    break; //Выход из цикла
                }

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
        }

        

    }
}
