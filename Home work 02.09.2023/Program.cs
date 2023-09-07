using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Home_work_02._09._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool checking_for_valid_input(string number_str) //Функция проверяющая корректность введенного числа
            {
                bool result_1_1 = double.TryParse(number_str, out double converted_number_1_2);
                if (result_1_1)
                {
                    return result_1_1;
                }
                else
                {
                    bool result_1_2 = int.TryParse(number_str, out int converted_number_1_1);
                    return result_1_2;
                }
            }
            {
                Console.WriteLine("Задача 1");                  //Первая задача
                Console.WriteLine("Мир Труд Май");
                Console.WriteLine("Мир\n  Труд\n      Май");

                Console.WriteLine("Задача 2");                  //Вторая задача
                Console.Write("Введите первое число: ");
                string number_1 = Console.ReadLine().Replace('.', ',');
                Console.Write("Введите второе число: ");
                string number_2 = Console.ReadLine().Replace('.', ',');
                bool result_of_checking_number_1 = checking_for_valid_input(number_1);
                bool result_of_checking_number_2 = checking_for_valid_input(number_2);
                if (result_of_checking_number_1 & result_of_checking_number_2)
                {
                    Console.WriteLine(number_2.Replace('.', ','));
                    Console.WriteLine(number_1.Replace('.', ','));
                }
                else if (result_of_checking_number_1 == false & result_of_checking_number_2 == false)
                {
                    Console.WriteLine("Некорректно введены оба числа");
                }
                else
                {
                    if (result_of_checking_number_1 == false)
                    {
                        Console.WriteLine("Некорректно введено 1 число");
                    }
                    else if (result_of_checking_number_2 == false)
                    {
                        Console.WriteLine("Некорректно введено 2 число");
                    }
                }

                Console.WriteLine("Задача 3");                   //Третья задача
                Console.Write("Введите радиус окружности: ");
                string radius_str = Console.ReadLine().Replace(".", ",");
                if (checking_for_valid_input(radius_str))
                {
                    double radius = double.Parse(radius_str);
                    double circumference = 2 * radius * Math.PI;
                    double area_of_a_circle = Math.PI * Math.Pow(radius, 2);
                    Console.WriteLine($"Длина окружности: {circumference}\nПлощадь круга: {area_of_a_circle}");
                }
                else
                {
                    Console.WriteLine("Некорректный ввод");
                }

                Console.WriteLine("Задача 4");                //Четвертая задача 
                Console.Write("Введите угол в градусах: ");
                string angle_in_radians_str = Console.ReadLine();
                if (checking_for_valid_input(angle_in_radians_str))
                {
                    double angle_in_radians = double.Parse(angle_in_radians_str);
                    double cosine_of_an_angle = Math.Cos(angle_in_radians);
                    Console.WriteLine(cosine_of_an_angle);
                }
                else
                {
                    Console.WriteLine("Некорректный ввод");
                }

                Console.WriteLine("Задача 5");                  //Пятая задача
                Console.Write("Введите коэффицент a: ");
                string coefficient_a_str = Console.ReadLine();
                Console.Write("Введите коэффицент b: ");
                string coefficient_b_str = Console.ReadLine();
                Console.Write("Введите коэффицент c: ");
                string coefficient_c_str = Console.ReadLine();
                if (checking_for_valid_input(coefficient_a_str) == true & checking_for_valid_input(coefficient_b_str) == true & checking_for_valid_input(coefficient_c_str) == true)
                {
                    double coefficient_a = double.Parse(coefficient_a_str);
                    double coefficient_b = double.Parse(coefficient_b_str);
                    double coefficient_c = double.Parse(coefficient_c_str);
                    double discriminant = (Math.Pow(coefficient_b, 2)) - (4 * coefficient_a * coefficient_c);
                    if (discriminant > 0)
                    {
                        double x1 = ((-coefficient_b + Math.Sqrt(discriminant)) / (2 * coefficient_a));
                        double x2 = ((-coefficient_b + Math.Sqrt(discriminant)) / (2 * coefficient_a));
                        Console.WriteLine($"{x1}\n{x2}");
                    }
                    else if (discriminant == 0)
                    {
                        double x = ((-coefficient_b) / (2 * coefficient_a));
                        Console.WriteLine(x);
                    }
                    else
                    {
                        Console.WriteLine("Дискриминант меньше нуля, решения нет");
                    }
                }
                else
                {
                    Console.WriteLine("Некорректный ввод");
                }

                Console.WriteLine("Задача 6");                  //Шестая задача
                Console.Write("Введите переменную a: ");
                string variable_a_str = Console.ReadLine();
                Console.Write("Введите переменную b: ");
                string variable_b_str = Console.ReadLine();
                Console.Write("Введите переменную c: ");
                string variable_c_str = Console.ReadLine();
                Console.WriteLine($"Начальные значения\na b c\n{variable_a_str} {variable_b_str} {variable_c_str}");
                string variable_a = variable_a_str;
                string variable_b = variable_b_str;
                string variable_c = variable_c_str;
                variable_a_str = variable_b;
                variable_b_str = variable_c;
                variable_c_str = variable_a;
                Console.WriteLine($"Изменения 1\n{variable_a_str} {variable_b_str} {variable_c_str}");
                variable_a_str = variable_c;
                variable_b_str = variable_a;
                variable_c_str = variable_b;
                Console.WriteLine($"Изменения 2\n{variable_a_str} {variable_b_str} {variable_c_str}");

                Console.WriteLine("Задача 7");                  //Седьмая задача
                Random rnd = new Random();
                for (int i = 0; i < 4; i++)
                {
                    int random_value = rnd.Next();
                    Console.WriteLine(random_value);
                }

                Console.WriteLine("Задача 8");                  //Восьмая задача
                Random rand = new Random();
                string random_number = rand.Next(100, 999).ToString();
                Console.WriteLine(random_number);
                Console.WriteLine(random_number[2] + random_number.Substring(0, 2));

                Console.WriteLine("Задача 9");                  //Девятая задача
                Console.WriteLine("Конфеты стоят 200 за 1 кг\nПеченье стоит 100 за 1 кг\nЯблоки стоят 80 за 1 кг");
                Console.Write("Введите вес конфет: ");
                string candy_weight_str = Console.ReadLine().Replace(".", ",");
                Console.Write("Введите вес печенья: ");
                string cookie_weight_str = Console.ReadLine().Replace(".", ",");
                Console.Write("Введите вес яблок: ");
                string apple_weight_str = Console.ReadLine().Replace(".", ",");
                Console.WriteLine(random_number);
                if (checking_for_valid_input(candy_weight_str) == true & checking_for_valid_input(cookie_weight_str) == true & checking_for_valid_input(apple_weight_str) == true)
                {
                    double candy_weight = double.Parse(candy_weight_str);
                    double cookie_weight = double.Parse(cookie_weight_str);
                    double apple_weight = double.Parse(apple_weight_str);
                    Console.WriteLine($"Цена конфет {candy_weight * 200} за {candy_weight} кг\nЦена печенья " +
                        $"{cookie_weight * 100} за {cookie_weight} кг\nЦена яблок {apple_weight * 80} за {apple_weight} кг");
                }
                else
                {
                    Console.WriteLine("Некорректно введены данные");
                }
            }
        }
    }
}
