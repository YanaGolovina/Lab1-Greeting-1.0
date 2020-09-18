using System;

namespace Yourold
{
    class Program
    {
        static void Main(string[] args)
        {
            bool proverka = true;
            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите день вашего рождения");
            int bday = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц вашего рождения");
            int bmounth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите год вашего рождения");
            int byear = Convert.ToInt32(Console.ReadLine());

            if (bmounth > 12 || bmounth < 1)
            {
                Console.WriteLine("Месяц не коректен");
                proverka = false;
            }
            if (bday > 31 || bday < 1)
            {
                Console.WriteLine("День не коректен");
                proverka = false;
            }
            if (byear < 1|| byear >2020)
            {
                Console.WriteLine("Год не коректен");
                proverka = false;
            }
            if (bmounth == 2)
            {
                if (((byear % 4 == 0) & (byear % 100 != 0)) || (byear % 400 == 0))
                {
                    if (bday > 29)
                    {
                        Console.WriteLine("День не коректен");
                        proverka = false;
                    }
                    else if (bday > 28)
                    {
                        Console.WriteLine("День не коректен");
                        proverka = false;
                    }
                }
            }
            if (bmounth == 4 || bmounth == 6 || bmounth == 9 || bmounth == 11)
            {
                if (bday > 30)
                {
                    Console.WriteLine("День не коректен");
                    proverka = false;
                }
            }
            if (proverka == true)
            {
                int age;
                DateTime someDate = DateTime.Now;
                if (bmounth < someDate.Month)
                {
                    age = someDate.Year - byear;
                    Console.WriteLine($"Привет {name},вам {age} лет");
                }
                else if (bmounth > someDate.Month)
                {
                    age = someDate.Year - byear - 1;
                    Console.WriteLine($"Привет {name},вам {age} лет");
                }
                else if (bday < someDate.Day)
                {
                    age = someDate.Year - byear;
                    Console.WriteLine($"Привет {name},вам {age} лет");
                }
                else if (bday > someDate.Day)
                {
                    age = someDate.Year - byear - 1;
                    Console.WriteLine($"Привет {name},вам {age} лет");
                }
                else
                {
                    age = someDate.Year - byear;
                    Console.WriteLine($"Привет, {name},вам {age} лет.С днём рождения!!");
                }
            }
            Console.ReadKey();
        }
    }
}


