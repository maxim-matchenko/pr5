//**********************************************************
//* Практическая работа N5                                 *
//* Выполнил:Матченко M.C., группа 2-ИСП-оКФ               *
//* Вариант 4                                              *
//* Задание: составить программу работы алгоритма ветвления*
//**********************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr5
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            int a, b, c; // объявление переменных
            Console.Title = "Практическая работа №5"; // заголовок консоли
            Console.WriteLine("Здравствуйте!");
            Console.Write("Введите три числа:\n");
            Console.Write("a = ");   // ввод исходных данных
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("с = ");
            c = Convert.ToInt32(Console.ReadLine());
            // Проверка условия
            if (a > 0 && b > 0 && c > 0) 
            {      
                Console.WriteLine("\nВысказывание истинно, все числа положительные");  
            }
            else
            { 
                Console.WriteLine("\nВысказывание ложно. Не соответсствует условию");
                Console.WriteLine("\nЭти числа не дают выполнить условие:");
                if (a <= 0)
            {
                    Console.WriteLine("Число a = " + a);
            }
            if (b <= 0)
            {
                    Console.WriteLine("Число b = " + b);
            }
            if (c <= 0)
            {
                    Console.WriteLine("Число c = " + c);
                }
            }
            Console.ReadKey();
        }
    }
}