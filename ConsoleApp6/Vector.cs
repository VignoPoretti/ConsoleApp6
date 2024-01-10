using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Vector
    {
        public float X { get; set; }

        public float Y { get; set; }

        public Vector(float x, float y)
        {
            X = x;
            Y = y;
        }

        public Vector somma(Vector v)
        {
            float x= v.X+this.X;
            float y= v.Y+this.Y;

            return( new Vector(x,y));
        }
        public static Vector Parse(string s)
        {
            string[] Coord= s.Split(',');
            float x= float.Parse(Coord[0]);
            float y= float.Parse(Coord[1]);   
            return (new Vector(x,y));
        }
    }
}
