using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Калмыков

//Решить задачу с логинами из предыдущего урока, только логины и пароли считать из файла в массив. 
//Создайте структуру Account, содержащую Login и Password.

namespace Mission3
{
    class Program
    {
        static void Main(string[] args)
        {

            Account Acc;
            Acc.dbLogin = "";
            Acc.dbPass = "";
            Acc.ReadFile();
            Console.WriteLine($"Введите логин:");
            string LoginConsole = Console.ReadLine();
            Console.WriteLine($"Введите пароль:");
            string PassConsole = Console.ReadLine();
            bool check = Acc.Checkout(LoginConsole, PassConsole);
            int shot = 1;

            do
            {
                shot++;
                if (check == false)
                {
                    Console.WriteLine("Данные введени не верно.");
                    Console.WriteLine($"Введите логин:");
                    LoginConsole = Console.ReadLine();
                    Console.WriteLine($"Введите пароль:");
                    PassConsole = Console.ReadLine();
                    check = Acc.Checkout(LoginConsole, PassConsole);
                }

                if (check == true)
                {
                    Console.WriteLine("Добро пожаловать!");
                    goto end;
                }

            } while (shot !=3);

            Console.WriteLine("У вас закончились попытки.");
            end:
            Console.ReadKey();
        }
    }
}
