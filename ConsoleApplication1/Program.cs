using ConsoleApplication1.LIB.Model;
using GeneratorName;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMenu();
            int choice = Int32.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {

                    }
                    break;
                case 2:
                    {
                        if(ServiceUser.Registration(GetUseInfoForRegist()))
                        {
                            Console.WriteLine("register ok");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("error");
                        }

                    }
                    break;
                default:
                    break;
            }

        }
        static public void PrintMenu()
        {
            Console.WriteLine("1.Войди\n2.Регистрация");
        }
        static public User GetUseInfoForRegist()
        {
            User user = new User();
            Console.Write("{0, -40}", "Введите ФИО:");
            user.FullName = Console.ReadLine();
            Console.Write("{0, -40}", "Введите ИИН:");
            user.IIN = Console.ReadLine();
            Console.Write("{0, -40}", "Введите Дату рождения:");
            user.DoB = DateTime.Parse(Console.ReadLine());
            Console.Write("{0, -40}", "Введите пол (0-Ж, 1-М):");
         
            user.Sex = (Gender)Int32.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");
            Console.WriteLine("{0, -40}", "Выберите логин:");
            user.login = Console.ReadLine();

            Console.WriteLine("{0, -40}", "Выберите пароль:");
            user.password = Console.ReadLine();
            Console.WriteLine("------------------------------");
            user.CreateDate = DateTime.Now;
            user.IsBlock = false;

            return user;
        }
    }
}
