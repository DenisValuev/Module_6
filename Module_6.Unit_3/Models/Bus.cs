using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_6.Unit_3.Models
{
    internal class Bus
    {
        public int? Load;
        public void PrintStatus()
        {
            if (Load.HasValue && Load > 0) 
            {
                Console.WriteLine("Количество пассажиров {0}", Load.Value);
            }
            else 
            {
                Console.WriteLine("Автобус пуст!");
            }
        }
    }
}
