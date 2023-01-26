using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    class Program
    {
        
        static void Main()
        {
            Console.Write("Введите длину массива: ");
            int[] n = new int[Int32.Parse(Console.ReadLine())];
            Console.Write("Введите а (минимум числового диапозона): "); int a = Int32.Parse(Console.ReadLine());
            Console.Write("Введите б (максимум числового диапозона): "); int b = Int32.Parse(Console.ReadLine());
            n = Vvod(a, b, n);

            One(n);
            Two(n);
            Tree(n);
            Four(n);
            Five(n);
            Six(n);

            Console.ReadKey();
        }
        static int[] Vvod(int a, int b, int[] n)
        {
            Random rnd = new Random();
            if (a < b)
            {
                for (int i = 0; i < n.Length; i++)
                {
                    n[i] = (b - rnd.Next(b-a+1));
                    Console.Write(n[i] + " ");
                }
            }
            Console.WriteLine();
            return n;
        }
        static void One(int[] n)
        {
            int sum = 0;
            int otvet = 0;
            foreach (int i in n)
            {
                if (sum > 1) { otvet++; }
                if (i == 0) { sum++; }
            }
            if (sum > 1)
            {
                Console.WriteLine($"Задание 1. После 2-го нуля в массиве будет {otvet} числа.");
            }
            else { Console.WriteLine("Задание 1. В массиве нет 2-го нуля."); }
        }
        static void Two(int[] n)
        {

            int sum = 0;
            int k = 0;
            foreach (int i in n)
            {
                if (i > 0) { sum += i; k++; }
            }
            if (k > 0)
            {
                Console.WriteLine($"Задание 2. Среднее арифметическое положительных элементов массива: {sum / k}");
            }
            else { Console.WriteLine("Задание 2. Положительных элементов в массиве нет."); }
        }
        static void Tree(int[] n)
        {
            int sum = 0;
            int k = 0;
            foreach (int i in n)
            {
                if (i == 0) { sum++; }
                if (sum == 3) { break; }
                if (sum < 3) { k++; }
            }
            if (sum > 2)
            {
                Console.WriteLine($"Задание 3. До 3-го нуля в массиве {k} числа.");
            }
            else { Console.WriteLine("Задание 3. В массиве нет 3-го нуля."); }
        }
        static void Four(int[] n)
        {
            int sum = 0;
            foreach (int i in n)
            {
                if (i < 0) { sum += i; }
            }
            if(sum < 0)
            {
                Console.WriteLine($"Задание 4. Сумма отрицательных элементов массива: {sum}");
            }
            else { Console.WriteLine("Задание 4. Отрицательных элементов в массиве нет."); }
        }
        static void Five(int[] n)
        {
            int sum = 0;
            int k = 0;
            foreach (int i in n)
            {
                if (sum > 1 && sum < 3) { k++; }
                if (i == 0) { sum++; }
                if(sum == 3) { break; }
            }
            Console.WriteLine($"Задание 5. Между 1-м и 3-м нулями {k} чисел.");
        }
        static void Six(int[] n)
        {
            int sum = 0;
            int k = 0;
            foreach (int i in n)
            {
                if (i == 0) { sum++; }
                if (sum == 2) { break; }
                k++;
            }
            if(sum > 1)
            {
                Console.WriteLine($"Задание 6. Индекс второго нуля равен {k}.");
            }
            else { Console.WriteLine("Задание 6. Второго нуля нет."); }
        }
    }
}
