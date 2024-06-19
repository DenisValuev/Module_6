using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_6.Unite_2.Models
{
    internal struct Animal
    {
        //Поля структуры
        public string type;
        public string name;
        public int age;

        //Метод структуры
        public void Info()
        {
            Console.WriteLine("Это {0} по кличке {1}, ему {2}", type, name, age);
        }
    }
}
