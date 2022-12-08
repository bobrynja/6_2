using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void f()
        {
            try
            {
                Console.Write("Введите размер массива: ");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n <= 0) Console.WriteLine("Размер массива не может быть отрицательным или равным 0!!!");
                else
                {
                    double[] arr = new double[n];
                    Console.WriteLine("Введите числа: ");
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("a[" + i + "] = ");
                        arr[i] = Convert.ToDouble(Console.ReadLine());
                    }

                    double num = 0; //само максимальное число
                    int number = 0; //номер максимального числа
                    for (int i = 0; i < n; i++)
                    {
                        if (arr[i] >= num)
                        {
                            num = arr[i];
                            number = i + 1;
                        }
                    }
                    Console.WriteLine("Номер последнего максимального числа - " + number);
                }
            }
            catch { Console.WriteLine("Некорректный ввод данных!"); }
        }

        static void Main(string[] args)
        {
                f();
            Console.ReadKey();
        }
    }
}
