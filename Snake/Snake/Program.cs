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
            Console.SetBufferSize(80, 25);
            HorizontalLine upline = new HorizontalLine(0,78,0,'+');
            HorizontalLine downline = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftvline = new VerticalLine(0,24,0,'+');
            VerticalLine rightvline = new VerticalLine(0, 24, 78, '+');
            rightvline.Draw();
            upline.Draw();
            downline.Draw();
            leftvline.Draw();
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            snake.Move();
            snake.Move();
            snake.Move();
            snake.Move();
            snake.Move();

            Console.Read();



        }
        
    }
}
