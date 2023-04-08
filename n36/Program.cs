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
            
            void setArray(int n, int[] arr)
            {   // формирование массива случайных чисел
                Random rand = new Random();
                for(int i = 0; i < n; i++) 
                    arr[i] = rand.Next(0, 100);
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
            int[] mass = new int[size];
            
            setArray(size, mass);   
            outputArray(size, mass);
            outputVal(sumNeChet(mass, size));           
        }
    }
}
