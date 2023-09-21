using System;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace hw2
{
    public struct User
    {
        public string name;
        public string town;
        public byte age;
        public short pin;
    }
    public class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Задача 2:");
                Console.WriteLine("( ! после каждого введения данных необходимо нажимать Enter ! )");
                Console.Write("Введите своё имя: ");
                User user = new User();
                user.name = Console.ReadLine();
                Console.Write("Введите свой город: ");
                user.town = Console.ReadLine();
                Console.Write("Введите свой возраст: ");
                string age = Console.ReadLine();
                byte a;
                bool flag = byte.TryParse(age, out a);
                if (!flag)
                {
                    Console.Write("Введите свой возраст ещё раз: ");
                    user.age = Convert.ToByte(Console.ReadLine());
                }
                else
                {
                    user.age = Convert.ToByte(age);
                }
                Console.Write("Введите пин-код: ");
                string pin = Console.ReadLine();
                short p;
                flag = short.TryParse(pin, out p);
                if (!flag)
                {
                    Console.Write("Введите свой пин-код ещё раз: ");
                    user.pin = Convert.ToInt16(Console.ReadLine());
                }
                else
                {
                    user.pin = Convert.ToInt16(pin);
                }
                Console.WriteLine($"\nИмя пользователя: {user.name}\nГород: {user.town}\nВозраст: {user.age}\nПин-код: {user.pin}");
            }
            Console.WriteLine("");
            {
                Console.WriteLine("Задача 3:");
                Console.Write("Введите строку, содержащую строчные и заглавные буквы ( нажмите Enter после окончания ): ");
                string line = Console.ReadLine();
                string new_line = "";
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] != line.ToUpper()[i])
                    {
                        new_line += line.ToUpper()[i];
                    }
                    else
                    {
                        new_line += line.ToLower()[i];
                    }
                }
                Console.WriteLine(new_line);
            }
            Console.WriteLine("");
            {
                Console.WriteLine("Задача 4:");
                Console.WriteLine("( данная программа будет находить количество вхождений подстроки в строку! )");
                Console.WriteLine("( после введения нажимайте Enter )");
                Console.Write("Введите строку: ");
                string line = Console.ReadLine();
                Console.Write("Введите подстроку: ");
                string sub_line = Console.ReadLine();
                int count = Regex.Matches(line, sub_line).Count;
                Console.Write("Количество вхождений: {0}", count);
            }
            Console.WriteLine("");
            {
                Console.WriteLine("Разговор Гарри и дневника Тома:");
                Console.WriteLine("Как тебя зовут ?");
                string username = Console.ReadLine();
                Console.WriteLine("Привет, {0} !", username);
                Console.WriteLine("да ...");
                Console.WriteLine("нет");
                Task taskA = new Task(() => Console.WriteLine("Но могу показать ."));
                Task taskB = new Task(() => Console.BackgroundColor = ConsoleColor.Blue);
                Console.WriteLine("Выбирите вопрос который хотите задать незнакомцу:\n1:Кто ты?\n2:Можно ли выбраться отсюда?\n0:Продолжить путь.");
                ConsoleKey key = Console.ReadKey().Key;
                do
                {
                    if (key == ConsoleKey.D1)
                    {
                        Console.WriteLine("-Я Джосеф. Я не был христианином и за это очутился здесь.");
                    }
                    else
                    {
                        Console.WriteLine("-Нужно пройти все круги ада и сразиться со всеми стражами.");
                    }
                    key = Console.ReadKey().Key; //ожидаете нажатия
                }
                while (key != ConsoleKey.D0);
                Console.WriteLine("Вы продолжили свой путь.");


            }
        }
    }
}