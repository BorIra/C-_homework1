//Вход: числа, которые ввел пользователь
// Вывод: сколько чисел > 0
using System;      
using System.Collections; 

namespace exp41     
{
    class PologitNum   
    {
        static ArrayList NewCollection()
        {   
            ArrayList nums = new ArrayList();
            string str = "";
            try 
            {
                while (true)
                {
                    Console.Write("Введите число (если все числа введены введите символ): ");
                    str = Console.ReadLine();
                    if (str != "n")nums.Add(Convert.ToDouble(str));             
                }
            }
            catch (Exception ex) 
            {
                
            }
            
            return nums;
        }

        static int  getNumPologit(ArrayList arr)
            {   
                int count = 0;
                foreach(double a in arr)
                    if (a > 0) count ++;
                return count;
            }
        
        static void Main(string[] str) 
        {
            ArrayList arrOfNums = NewCollection();
            Console.WriteLine("Положительных чисел в массиве - {0:d}", getNumPologit(arrOfNums));
        }
    }
}