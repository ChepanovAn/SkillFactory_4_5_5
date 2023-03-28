using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory_4_5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            (string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age) User;

            Console.WriteLine("Введите возраст пользователя");
            User.Age = Convert.ToDouble(Console.ReadLine());

            User.favcolors = new string[3];
            Console.WriteLine("Введите три любимых цвета пользователя");

            for (int i = 0; i < 3; i++)
            {
                User.favcolors[i] = Console.ReadLine();
            }
            Console.WriteLine(User.favcolors);
        }
    }
}
