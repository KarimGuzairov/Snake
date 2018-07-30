using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Point p1 = new Point(1,3,'*');
           
            p1.Draw();
            
            Point p2 = new Point(4,5,'#');
          
            p2.Draw();
            

            Console.SetBufferSize(150, 40); */

            HorizontalLine Upline = new HorizontalLine(0, 118, 0, '+');
            HorizontalLine Downline = new HorizontalLine(0, 118, 29, '+');
            VerticalLine Leftline = new VerticalLine(0, 29, 0, '+');
            VerticalLine Rightline = new VerticalLine(0, 29, 118, '+');


            Upline.Drow();
            Downline.Drow();
            Leftline.Drow();
            Rightline.Drow();

            Console.ReadKey();
        
           
        }

        

    }
}
