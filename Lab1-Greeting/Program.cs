using System;

namespace Lab1_Greeting_1._0
{
        class Greeting
        {
            static void Main(string[] args)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Здравствуйте. Введите своё имя.");
                string name = Console.ReadLine();
                Console.WriteLine("Введите год Вашего рождения.");
                int year = ReadAndCheckYaer();
                Console.WriteLine("Введите месяц Вашего рождения.");
                int mounth = ReadAndCheckMounth();
                Console.WriteLine("Введите день Вашего рождения.");
                int day = ReadAndChechDay(mounth, year);
                int age = CountAge(year, mounth, day);
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Привет, {0}.Ваш возраст равен {1} лет. Приятно познакомиться.", name, age);
                Console.ReadKey();
            }

            public static int ReadNumber()
            {
                bool isSuccess;

                int number;
                do
                {
                    isSuccess = int.TryParse(Console.ReadLine(), out number);
                    if (!isSuccess)
                        Console.WriteLine("Увы. Вы ввели не цифры, попробуйте ещё раз.");
                } while (!isSuccess);
                return number;
            }

            public static int ReadAndCheckYaer()
            {
                int year = ReadNumber();
                while (!(year > 0 && year < DateTime.Now.Year - 1))
                {
                    Console.WriteLine("Год не подходит, введите корректный год.");
                    year = ReadNumber();
                }
                return year;
            }

            public static int ReadAndCheckMounth()
            {
                int num = ReadNumber();
                while (!(num > 0 && num < 13))
                {
                    Console.WriteLine("Месяц не подходит, введите корректный месяц.");
                    num = ReadNumber();
                }
                return num;
            }

            public static bool CheckMounth(int numOfMounth, int day)
            {
            if (numOfMounth == 1 || numOfMounth == 3 || numOfMounth == 5 ||
                            numOfMounth == 7 || numOfMounth == 8 || numOfMounth == 10 || numOfMounth == 12)
                return (day < 32);
            else return (day < 31);

            }

            public static int ReadAndChechDay(int mounth, int year)
            {
                int day;
                bool isSuccess;
                do
                {
                    day = ReadNumber();
                    while (!(day > 0 && day < 32))
                    {
                        Console.WriteLine("День не корректен, введите ещё раз.");
                        day = ReadNumber();
                    }

                    if (mounth == 2)
                        isSuccess = ChekFebruary(day, year);
                    else
                        isSuccess = CheckMounth(mounth, day);
                } while (isSuccess != true);
                return day;
            }

            public static bool ChekFebruary(int day, int year)
            {
                if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                    return (day < 30);
                else return (day < 29);
            }

            public static int CountAge(int year, int mounth, int day)
            {
                int age;
                DateTime now = DateTime.Now;
                if (now.Month < mounth)
                    age = now.Year - year - 1;
                else
                    if (now.Month == mounth)
                    if (now.Day >= day)
                        age = now.Year - year;
                    else age = now.Year - year - 1;
                else 
                    age = now.Year - year;
                return age;
            }
        }
}
