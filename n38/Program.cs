//Вход: массив случайных чисел
// Вывод: разница между максимальным и минимальным элементами массива
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
                Console.Write("Разность между max и min элементами массива: {0:d}", val);
            }

            int raznost(int[] arr, int n)
            {   // разность между max и min элементами массива
                int max = arr[0];
                int min = arr[0];
                for (int i = 1; i < n; i ++)
                {
                    if (arr[i] > max) max = arr[i];
                    if (arr[i] < min) min = arr[i];
                }
                return max - min;
            }
            
            int size = setVal();
            int[] mass = setArray(size, 0, 100);
            
            outputArray(size, mass);
            outputVal(raznost(mass, size));           
        }
    }
}
