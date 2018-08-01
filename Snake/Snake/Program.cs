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
            Point p = new Point(4, 5, '*'); // ������� ������ ������
            Snake snake = new Snake(p, 4, Direction.RIGHT, false); //�������� ������� ������
            snake.Draw(); // ��������� ������� ������

            FoodCreator foodCreator = new FoodCreator(117, 28, '$'); //������� ������ �������� "���" � ������ ��� "���"
            Point food = foodCreator.CreateFood(); // �������� ����� food
            food.Draw(); //��������� ����� food

            Walls walls = new Walls(117, 28); //�������� ������� walls
            walls.Draw(); // ��������� ����������� � ����� �������� ����

            while(true) //����������� ����, � ������� ���������� �������� ������, ���� ������� � �������� �� ������������ � �������������
            {
                if (walls.IsHit (snake) || snake.IsHitTail()) // ������ || �������� "���".
                {
                    break; //����� �� �����
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
