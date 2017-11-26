using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            Console.ReadLine();
        }

        private static void Task5()
        {
            Console.Write("Введите число: ");
            string str = Console.ReadLine();
            str.Reverse();
            Console.Write("Результат: ");
            Console.WriteLine(str);
        }

        private static void Task4()
        {
            int A, B;
            Console.WriteLine("Ввелите число A");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Ввелите число B");
            B = int.Parse(Console.ReadLine());
            for (int i = A; i < B; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        private static void Task3()
        {
            bool SwitchForWhile = true;
            StringBuilder str = null;
            Console.WriteLine("Введите строку, поставте точку когда захотите завершить ввод");
            str.Append(Console.ReadLine());
            char tmp;
            while (SwitchForWhile == true)
            {
                tmp = char.Parse(Console.ReadLine());
                if (tmp != '.')
                {
                    str.Append(str + tmp.ToString());
                }
                else
                {
                    SwitchForWhile = false;
                    for (int i = 0; i < str.Length; i++)
                    {
                        str[i] = (char)(str[i] + 32);
                    }
                    string FinishStr = str.ToString();
                    Console.Write("Резльтат; ");
                    Console.WriteLine(FinishStr);
                }
            }
        }

        private static void Task2()
        {
            const int DivisorHundred = 100, DivisorTen = 10, DivisorUnit = 1;
            int number;
            int[] firstHalf = new int[3], secondHalf = new int[3];
            int firstHalfAll, secondHalfAll;
            Console.WriteLine("--------------------");
            Console.WriteLine("Введите число");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("Число - ");
            firstHalf[0] = number / DivisorHundred;
            firstHalf[1] = (number % DivisorHundred) / DivisorTen;
            firstHalf[2] = ((number % DivisorHundred) % DivisorTen) / DivisorUnit;
            secondHalf[0] = number / DivisorHundred;
            secondHalf[1] = (number % DivisorHundred) / DivisorTen;
            secondHalf[2] = ((number % DivisorHundred) % DivisorTen) / DivisorUnit;
            firstHalfAll = firstHalf[0] + firstHalf[1] + firstHalf[2];
            secondHalfAll = secondHalf[0] + secondHalf[1] + secondHalf[2];
            if (firstHalfAll == secondHalfAll)
            {
                Console.WriteLine("Билет счастливый");
            }
            else
            {
                Console.WriteLine("Билет не счастливый");
            }
        }

        private static void Task1()
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            string[] mas = str.Split('.');
            int probel = 0;
            for (int i = 0; i < mas[0].Length; i++)
            {
                if (mas[0][i] == ' ')
                {
                    probel++;
                }
            }
            Console.Write("Строка - ");
            Console.WriteLine(mas[0]);
            Console.Write("Количество пробелов = ");
            Console.WriteLine(probel);
        }
    }
}
