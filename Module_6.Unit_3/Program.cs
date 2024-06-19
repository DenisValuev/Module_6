using Module_6.Unit_3.Models;

namespace Module_6.Unit_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department();
            department.Company = new Company { Type = "Банк"};
            department.City = new City { Name = "Санкт-Петербург" }; 
            if (department?.Company?.Type == "Банк" && department?.City?.Name == "Санкт-Петербург")
            {
                Console.WriteLine("У банка {0} есть отделение в Санкт-Петербурге", department?.Company?.Name ?? "Неизвестная компания");
            }
        }
    }
}
