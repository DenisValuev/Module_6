using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_6.Unit_6.Models
{
    internal class User
    {
		private int age;
		private string mail;
		private string login;

		public string Login
		{
			get { return login; }
			set 
			{
				if (value.Length < 3)
				{
					Console.WriteLine("Поле логина должно быть не менее 3 символов длиной");
				}
				else
				{
                    login = value;
                }
			}
		}

		public string Mail
		{
			get { return mail; }
			set 
			{
				if (value.Contains('@'))
				{
					mail = value;
				}
				else 
				{
                    Console.WriteLine("Неверный формат почты");
                }
					
			}
		}

		public int Age
		{
			get { return age; }
			set
			{
                if (value < 18)
                {
                    Console.WriteLine("Возраст должен быть не меньше 18");
                }
                else
                {

                    age = value;
                }
            }	
		}

	}
}
