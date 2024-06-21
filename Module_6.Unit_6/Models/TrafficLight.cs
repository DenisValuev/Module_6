using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_6.Unit_6.Models
{
    internal class TrafficLight
    {
        private string _color;
        private void ChangeColor(string color)
        { 
            _color = color;
        }
        public string GetColor()
        {
            return _color;
        }
    }
}
