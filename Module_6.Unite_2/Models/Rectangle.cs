using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_6.Unite_2.Models
{
    internal class Rectangle
    {
        public int a;
        public int b;
        public Rectangle()
        {
            a = 6;
            b = 4;
        }
        public Rectangle(int _a, int _b )
        {
            a= _a;
            b= _b;
        }
        public Rectangle(int side)
        {
            a = b = side;
        }
        public int Square()
        {
            return a * b;
        }
    }
}
