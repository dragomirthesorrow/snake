using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sys;

        public Point() {
                    }
        public Point(int _x, int _y, char _sys)
        {
            x = _x;
            y = _y;
            sys = _sys;
        }
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sys = p.sys;
        }

        public void Move(int offset, Direction direction)
        {
            if(direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if (direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if (direction == Direction.DOWN)
            {
                y = y + offset;
            }
            else if (direction == Direction.UP)
            {
                y = y - offset;
            }
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sys);
        }
        public void Clear()
        {
            sys = ' ';
            Draw();
        }
        public override string ToString()
        {
                return x + "," + y + "," + sys;
            }
        }
        }
    

