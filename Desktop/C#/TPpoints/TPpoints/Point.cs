using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPpoints
{
    internal class Point
    {


        private int _y;
        private int _x;

        public int x
        {
            get { return _x; }
            
        }

        

        public int y
        { 
            get { return _y; }
            
        }

        
        public double distanceTo(Point p)
        {
            double distance = Math.Sqrt(Math.Pow(this._x - p._x, 2) + Math.Pow(this._y - p._y, 2));
            return distance;
        }


        public Point(int _x, int _y)
                {
                    this._x = x;
                    this._y = y;
                }


        public  Point()
        {
            _x = -1;    
            _y = -1;


        }

        



    }
}