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
            
            void setArray(int n, int[] arr)
            {   // формирование массива случайных чисел
                Random rand = new Random();
                for(int i = 0; i < n; i++) 
                    arr[i] = rand.Next(100, 1000);
            }
            
            void outputArray(int n, int[] arr)
            {   // вывод массива случайных чисел
                string text = "[";
                for (int i = 0; i < n-1; i ++) 
                    text = text + String.Format("{0:d}, ", arr[i]);
                text = text + String.Format("{0:d} ]", arr[n-1]);
               
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
            int[] mass = new int[size];
            
            setArray(size, mass);   
            outputArray(size, mass);
            outputVal(countChet(mass, size));           
        }
    }
}