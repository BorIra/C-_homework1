//Вход: массив из 8 цифр
// Вывод:  массив
using System;       
namespace exp30     
{
    class massiv   
    {

        static void Main(string[] str) 
        {
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
                text = text + String.Format("{0:d} ]", arr[n-1]);//" " + arr[n-1].ToString + "}";
               
                Console.Write(text);
            }
            
            int size = 8;
            int[] mass = new int[size];
            setArray(size, mass);   
            outputArray(size, mass);
        }
    }
}