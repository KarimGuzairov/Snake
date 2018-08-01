using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls  //рисует препятствия, в том числе VerticalLine и HorizontalLine
    {
        List<Figure> wallList; //В список фигур ниже добавляем классы-наследники, так как они также являются фигурами. Используем полиморфизм.

        public Walls (int mapWidth, int mapHeight) // Конструктор задает рамки игрового поля, входные аргументы это высота и ширина игрового поля
        {
            wallList = new List<Figure>(); // Создание пустого списка из фигур

            //Отрисовка рамочки
            HorizontalLine Upline = new HorizontalLine(0, mapWidth, 0, '+');
            HorizontalLine Downline = new HorizontalLine(0, mapWidth, mapHeight, '+');
            VerticalLine Leftline = new VerticalLine(0, mapHeight, 0, '+');
            VerticalLine Rightline = new VerticalLine(0, mapHeight, mapWidth, '+');
            //Заполнение списка фигур
            wallList.Add(Upline); 
            wallList.Add(Downline);
            wallList.Add(Leftline);
            wallList.Add(Rightline);

        }

        internal bool IsHit (Figure figure) // Проверка на столконовения одной из точек фигуры с препятствием из walllist
        {
            foreach(var wall in wallList)
            {
                if(wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }

    }

}
