using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_6.Unite_2.Models
{
    internal class Pen
    {
        public string color;
        public int cost;
        public Pen()
        {
            color = "Черный";
            cost = 100;
        }
        public Pen(string penColor, int penCost)
        {
            color= penColor;
            cost = penCost;
        }
    }
}
