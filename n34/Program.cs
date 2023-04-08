//Вход: массив случайных трехчначных чисел
// Вывод: количество четных чисел в массиве
using System;       
namespace exp34     
{
    class chet   
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
                Console.Write("Количество четных чисел в массиве: {0:d}", val);
            }

            int countChet(int[] arr, int n)
            {   // подсчет количества четных элементов
                int col = 0;
                for (int i = 0; i < n; i ++)
                    if (arr[i] % 2 == 0) col ++;
                return col;
            }
            
            int size = setVal();
            int[] mass = setArray(size, 100, 1000);            
           
            outputArray(size, mass);
            outputVal(countChet(mass, size));           
        }
    }
}