using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задачи_по_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1.Написать программу, которая, реализует диалог с пользователем: запрашивает с клавиатуры два целых числа,
            //и выводит на экран сумму данных чисел.

            Console.Write("Привет! Введите пожалуйста 2 целых числа! \nx= ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y= ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine($"{x}+{y}={x + y}");
            Console.ReadKey();


            //2.Написать программу, которая, реализует диалог с пользователем: запрашивает с клавиатуры три целых числа,
            //и выводит на экран сумму данных чисел.

            Console.Write("Привет! Введите пожалуйста 3 целых числа! \nx= ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("y= ");
            int y2 = int.Parse(Console.ReadLine());
            Console.Write("z= ");
            int z3 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{x1}+{y2}+{z3}={x1 + y2 + z3}");
            Console.ReadKey();


            //3.Написать программу, которая, реализует диалог с пользователем: запрашивает
            //с клавиатуры два вещественных числа, и выводит на экран произведение данных чисел
            //(вещественные числа выводятся с точностью до 1 знака после запятой).

            Console.Write("Привет! Введите пожалуйста 2 вещественных числа! \nx= ");
            double xx = double.Parse(Console.ReadLine());
            Console.Write("y= ");
            double yy = double.Parse(Console.ReadLine());
            Console.WriteLine($"{xx:f1}*{yy:f1}={xx * yy:f1}");
            Console.ReadKey();


            //4.Написать программу, которая, реализует диалог с пользователем: запрашивает с клавиатуры два вещественных числа,
            //и выводит на экран результат деления первого числа на второе(вещественные числа выводятся с точностью до 3 знаков после запятой):

            Console.Write("Привет! Введите пожалуйста 2 вещественных числа! \nx= ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("y= ");
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"{x2:f3}/{y2:f3}={x2 / y2:f3}");
            Console.ReadKey();


            //5.Написать программу, которая, реализует диалог с пользователем: запрашивает с клавиатуры два целых числа,
            //и выводит на экран сумму данных чисел в прямом и обратном порядке:

            Console.Write("Привет! Введите пожалуйста 2 целых числа! \na= ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a}+{b}={b}+{a} \nДля продолжения нажмите любую клавишу . . .");
            Console.ReadKey();


            //6.Написать программу, которая запрашивает с клавиатуры два целых числа,
            //и выводит на экран результат их суммы, разности и произведения:

            Console.Write("Привет! Введите пожалуйста 2 целых числа! \na= ");
            int aa = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            int bb = int.Parse(Console.ReadLine());
            Console.WriteLine($"a+b={aa}+{bb}={bb + aa} \ta-b={aa}-{bb}={aa - bb} \ta*b={aa}*{bb}={aa * bb} \nДля продолжения нажмите любую клавишу . . .");
            Console.ReadKey();


            //7.Написать программу, которая, реализует диалог с пользователем:
            //запрашивает с клавиатуры имя человека и его возраст, и выводит на экран следующее сообщение (текущий год – 2009):

            Console.Write("Как тебя зовут?\t");
            string name = Console.ReadLine();
            Console.Write("Сколько тебе лет?\t");
            double age = double.Parse(Console.ReadLine());
            string genderMessage = (name.EndsWith("а") || name.EndsWith("я")) ? "родилась" : "родился";
            Console.Write($"{name}, ты {genderMessage} в {2009 - age} году \nPress any key to continue");
            Console.ReadKey();


            //7.Написать программу, которая, реализует диалог с пользователем:
            //запрашивает с клавиатуры имя человека и его возраст, и выводит на экран следующее сообщение (текущий год – 2009):

            Console.Write("Как тебя зовут?\t");
            string name = Console.ReadLine();
            Console.Write("Сколько тебе лет?\t");
            double age = double.Parse(Console.ReadLine());
            string genderMessage = (name.EndsWith("а") || name.EndsWith("я")) ? "родилась" : "родился";
            Console.Write($"{name}, ты {genderMessage} в {2009 - age} году \nPress any key to continue");
            Console.ReadKey();


            //8.Написать программу, которая, реализует диалог с пользователем: запрашивает с клавиатуры номинал купюры и количество купюр,
            //и выводит экран следующее сообщение:

            Console.Write("Здравствуйте! Введите пожалуйста..\nНоминал купюры: ");
            int banknote = int.Parse(Console.ReadLine());
            Console.Write("Количество купюр: ");
            int numberOfBanknotes = int.Parse(Console.ReadLine());
            Console.WriteLine($"Сумма денег: {banknote * numberOfBanknotes:f2}р. \nPress any key to continue");
            Console.ReadKey();


            //9.Написать программный код вычисления периметра квадрата со стороной а (P = 4*a).

            Console.Write("Привет! напиши значение для стороны квадрата:\na= ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine($"P = 4*a \nP = {a * 4}");
            Console.ReadKey();

            Random rnd = new Random();
            int a = rnd.Next(1, 5000);
            Console.WriteLine($"P = 4*a \nРандомное число: {a} \nP = {4 * a}");
            Console.ReadKey();


             //10.Написать программный код вычисления периметра прямоугольника со сторонами a и b (P=2*(a+b)).

             //№1
             Console.Write("Привет! напиши значение для сторон прямоугольника:\na= ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b= ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine($"P = 2*(a+b) \nP = {2 * (a + b)}");
            Console.ReadKey();
            //№2
            Random rnd = new Random();
            int a = rnd.Next(1, 5000);
            int b = rnd.Next(1, 5000);
            Console.WriteLine($"P = 2*(a + b) \nРандомные числа: a={a} b={b} \nP = {2 * (a + b)}");
            Console.ReadKey();
        }
    }
}
