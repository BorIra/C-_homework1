//Вход: массив случайных чисел
// Вывод: сумма элементов, стоящих на нечетных позициях в массиве
using System;       
namespace exp36     
{
    class sumNechet   
    {
        static void Main(string[] str) 
        {
            int setVal()
            {   // ввод размера массива
                Console.Write("Введите размер массива : ");
                return Convert.ToInt32(Console.ReadLine());
            }
            
            int[] setArray(int length, int minVal, int maxVal)
            {   // формирование массива случайных чисел
                int[] result = new int[length];
                Random rand = new Random();
                for(int i = 0; i < length; i++) 
                    result[i] = rand.Next(minVal, maxVal);
                return result;
            }
            
            void outputArray(int n, int[] arr)
            {   // вывод массива случайных чисел
                string text = "[" + string.Join(", ", arr) + "]";
                Console.WriteLine(text);
            }

            void outputVal(int val)
            {   // вывод результата на экран
                Console.Write("Сумма элементов, стоящих на нечетных позициях в массиве: {0:d}", val);
            }

            int sumNeChet(int[] arr, int n)
            {   // подсчет количества четных элементов
                int sum = 0;
                for (int i = 1; i < n; i += 2)
                    sum += arr[i];
                return sum;
            }
            
            int size = setVal();
            int[] mass = setArray(size, 0, 100);
            
            outputArray(size, mass);
            outputVal(sumNeChet(mass, size));           
        }
    }
}
