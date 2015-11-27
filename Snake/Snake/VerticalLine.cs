using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure
    {
        
        public VerticalLine(int yup, int ydown, int x, char sys)
        {
            pList = new List<Point>();
            for (int y = yup; y <= ydown; y++)
            {
                Point p = new Point(x, y, sys);
                pList.Add(p);
            }
        }

    }
}
