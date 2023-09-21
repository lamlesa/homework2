using System;
using System.Text.RegularExpressions;
using static hw2.Student;

namespace hw2
{
    public struct User
    {
        public string name;
        public string town;
        public byte age;
        public short pin;
    }
    public struct Student
    {
        public enum AlcoholCategories
        {
            a, b, c, d
        }
        public string surname;
        public string name;
        public short ID;
        public string birth_date;
        public AlcoholCategories category;
        public double volume;
        public double percentage;
    }
    public class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Задача 1:");
                Console.WriteLine("bool - true - false ;");
                Console.WriteLine("byte - 255 - 0 ;");
                Console.WriteLine("sbyte - 127 - -128 ;");
                Console.WriteLine("short - 32767 - -32768 ;");
                Console.WriteLine("ushort - 65535 - 0 ;");
                Console.WriteLine("int - 2147483647 - -2147483648 ;");
                Console.WriteLine("uint - 4294967295 - 0 ;");
                Console.WriteLine("long - 9223372036854775807 - –9223372036854775808 ;");
                Console.WriteLine("ulong - 18446744073709551615 - 0 ;");
                Console.WriteLine("float - 3.4*10^38 - -3.4*10^38 ;");
                Console.WriteLine("double - ±1.7*10^308 - ±5.0*10^-324 ;");
                Console.WriteLine("decimal - ±7.9228*10^28 - ±1.0*10^-28 ;");
                Console.WriteLine("char - 65535 - 0 ;");
                Console.WriteLine("decimal - ±7.9228*10^28 - ±1.0*10^-28 .");
            }
            Console.WriteLine("");
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
                if (!flag | pin.Length != 4)
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
                Console.WriteLine("Задача 6:");
                Console.WriteLine("Разговор Гарри и дневника Тома .");
                Console.WriteLine("Как тебя зовут ?");
                string username = Console.ReadLine();
                Console.WriteLine("Привет, {0} !", username);
                Console.BackgroundColor = ConsoleColor.Blue;
            }
            Console.WriteLine("");
            {
                Console.WriteLine("Задача 7:");
                Console.Write("Введите 12 цифр без пробелов: ");
                string line = Console.ReadLine();
                int ean = 0;
                for (int i = 1; i < line.Length; i += 2 )
                {
                    ean += int.Parse(Convert.ToString(line[i]));
                }
                ean = ean * 3;
                for (int i = 0; i < line.Length; i += 2)
                {
                    ean += int.Parse(Convert.ToString(line[i]));
                }
                ean = 10 - (ean % 10);
                Console.WriteLine($"EAN: {ean}");
            }
            Console.WriteLine("");
            {
                Console.WriteLine("Задача 8:");
                Student student1 = new Student();
                student1.surname = "Давлеев";
                student1.name = "Фаяз";
                student1.ID = 32767;
                student1.birth_date = "04.06.2005";
                student1.category = AlcoholCategories.a;
                student1.volume = 30.0;

                Student student2 = new Student();
                student2.surname = "Низамова";
                student2.name = "Сабина";
                student2.ID = 32766;
                student2.birth_date = "07.07.2005";
                student2.category = AlcoholCategories.a;
                student2.volume = 25.0;

                Student student3 = new Student();
                student3.surname = "Усманов";
                student3.name = "Тимур";
                student3.ID = 32765;
                student3.birth_date = "20.09.2005";
                student3.category = AlcoholCategories.a;
                student3.volume = 35.0;

                Student student4 = new Student();
                student4.surname = "Парамонова";
                student4.name = "Варвара";
                student4.ID = 32764;
                student4.birth_date = "23.04.2006";
                student4.category = AlcoholCategories.a;
                student4.volume = 20.0;

                Student student5 = new Student();
                student5.surname = "Прыгунов";
                student5.name = "Кирилл";
                student5.ID = 32763;
                student5.birth_date = "08.02.2005";
                student5.category = AlcoholCategories.a;
                student5.volume = 30.0;

                double general_volume = student1.volume + student2.volume + student3.volume + student4.volume + student5.volume;
                double percent = general_volume / 100;
                student1.percentage = student1.volume / percent;
                student2.percentage = student2.volume / percent;
                student3.percentage = student3.volume / percent;
                student4.percentage = student4.volume / percent;
                student5.percentage = student5.volume / percent;
                Console.WriteLine($"Общий объём = {general_volume}\n{student1.name} - {student1.percentage}%\n{student2.name} - {student2.percentage}%\n{student3.name} - {student3.percentage}%\n{student4.name} - {student4.percentage}%\n{student5.name} - {student5.percentage}%");
            }
            Console.WriteLine("");
        }
    }
}