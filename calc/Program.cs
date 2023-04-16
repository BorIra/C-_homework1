//Вход: k1, b1, k2, b2, где каждая пара k и b описывают прямую y=k*x+b
// Вывод: точка пересечения прямых
using System;       
namespace calc     
{
    class Calculate   
    {
        static Queue<string> elements = new Queue<string>();   // очередь из чисел и знаков операций
        static Dictionary<char, int> prioritetOperation = new Dictionary<char, int>()
        {   // определяем допустимые операции и их приоритет
            {'+', 1},
            {'-', 1},
            {'*', 1},
            {'/', 1}
        };
        static Stack<double> nums = new Stack<double>();  // стек чисел
        static Stack<char> ops = new Stack<char>(); // стек операций и скобок

        static string getString()
        {  
            Console.Write("Введите выражение для вычисления: ");
            return Console.ReadLine();
        }

        static void setElements(string str)
        {   // разбор строки на подстроки и запись в очередь
            string tmp = "";
            int count = 0;
            for(int i = 0; i < str.Length; i ++)
            {
                if(str[i]>='0' && str[i]<='9' || str[i]=='.') 
                {
                    tmp += str[i];
                    count++;
                }
                else if (prioritetOperation.ContainsKey(str[i]) || str[i] == '(' || str[i] == ')') 
                {
                    if (tmp != "") elements.Enqueue(tmp);
                    elements.Enqueue(str[i].ToString());
                    tmp = "";
                    count ++;
                }
                //else Console.Write("Ошибка ввода");
               //тут должен быть выход из программы
            }
            if(tmp != "") elements.Enqueue(tmp);
            tmp = "";
           /* foreach (string s in elements)
            {
                Console.Write(s + ", ");
            }*/
        }

        static double operation()
        {
            double rez = 0;
            if (nums.Count<2) return 0;
            double b = nums.Pop();
            double a = nums.Pop();
            switch (ops.Pop())
            {
                case '+' : rez  = a+b; break;
                case '-' : rez  = a-b; break;
                case '*' : rez  = a*b; break;
                case '/' : rez  = a/b; break;
            }
            return rez;
        }
        static void decision()
        {            
            string tmp;
            while(elements.Count > 0)
            {
                tmp = elements.Peek();
                if (prioritetOperation.ContainsKey(tmp[0]))
                { // знак
                  ops.Push(tmp[0]);
                }
                else if (tmp == "(")
                {
                    ops.Push(tmp[0]);  
                }
                else if (tmp == ")")
                { // скобки
                    ops.Push(tmp[0]); // temp
                }
                else 
                { // число
                    nums.Push(Convert.ToDouble(tmp));  
                }
            }
            if (nums.Count > 0)
            foreach ( double d in nums)
            {
                Console.Write("{0:n}, ", d);
            }
            Console.WriteLine();
            if (ops.Count>0)
            foreach (char c in ops)
            {
                Console.Write("{0}, ", c);
            }
        }

        static void Main(string[] str) 
        {
            setElements(getString());
            decision();
        }
    }
}