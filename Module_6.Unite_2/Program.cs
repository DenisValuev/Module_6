using Module_6.Unite_2.Models;

namespace Module_6.Unite_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Инициализация класса Human
            Human human = new Human();
            human.Greetings();

            human = new Human("Денис");
            human.Greetings();

            human = new Human("Денис", 32);
            human.Greetings();

            human = new Human { name = "Дмитрий", age = 20};
            human.Greetings();
        }
    }
}
