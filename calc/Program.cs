//Вход: строка-выражение для вычисления
// Вывод: вычислить выражение. Калькулятор.
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
            {'*', 2},
            {'/', 2}
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
                if(str[i]>='0' && str[i]<='9' || str[i]==',') 
                {   // собираем число из символов
                    tmp += str[i];
                    count++;
                }
                else if (prioritetOperation.ContainsKey(str[i]) || str[i] == '(' || str[i] == ')') 
                {
                    if (tmp != "") elements.Enqueue(tmp);   // число в очередь
                    elements.Enqueue(str[i].ToString());    // знак в очередь
                    tmp = "";
                    count ++;
                }
                //else Console.Write("Ошибка ввода"); // еще тут должен быть выход из программы
            }
            if(tmp != "") elements.Enqueue(tmp);    // последнее число в очередь, если оно есть
            tmp = "";
        }

        static double operation()
        {   // выполнение операции над двумя цифрами
            double rez = 0;
            if (nums.Count<2) return 0; // выход, если цифр в стеке недостаточно
            double b = nums.Pop();      // извлекаем пару цифр
            double a = nums.Pop();
            switch (ops.Pop())          // определяем операцию по знаку
            {
                case '+' : rez  = a+b; Console.WriteLine("{0} + {1} = {2}", a, b, rez); break;
                case '-' : rez  = a-b; Console.WriteLine("{0} - {1} = {2}", a, b, rez); break;
                case '*' : rez  = a*b; Console.WriteLine("{0} * {1} = {2}", a, b, rez); break;
                case '/' : rez  = a/b; Console.WriteLine("{0} / {1} = {2}", a, b, rez); break;
                default: break;
            }
            return rez;
        }

        static void decision()
        {   // вычисляем все выражение         
            string tmp;
            while(elements.Count > 0)
            {   // пока в очереди не закончились элементы
                tmp = elements.Dequeue();   // извлекаем элемент из очереди
               
                if (prioritetOperation.ContainsKey(tmp[0]))
                { // знак
                    while (true)
                    {   
                        // разбираемся со скобками и приоритетами предыдущего знака в стеке
                        int skobka = 0;
                        if (ops.Count > 0) 
                        {
                           if(ops.Peek() == '(') skobka = -10;
                           else skobka = prioritetOperation[ops.Peek()];
                        }
                        // определяем нужно ли проводить операцию над числами, или нет
                        bool notNeedToCalc = ops.Count == 0 || 
                                        prioritetOperation[tmp[0]] > skobka;
                        
                        if (notNeedToCalc) 
                        {   
                            ops.Push(tmp[0]);                            
                            break;
                        }  
                        else nums.Push(operation());                         
                    }                    
                }
                else if (tmp == "(")
                {  // открывающую скобку просто добавим в стек
                    ops.Push(tmp[0]);  
                }
                else if (tmp == ")")
                {   // вычисляем значение в скобках до тех пор, пока не вернемся к открывающей скобке
                    while(true)
                    {
                        if (ops.Peek() == '(') 
                        {
                            ops.Pop();
                            break;
                        }
                        nums.Push(operation());                        
                    }
                }
                else 
                { // число просто добавим в стек чисел
                    nums.Push(Convert.ToDouble(tmp));         
                }
            }

            while(true)
            {   // выполняем операции над числами, если стек знаков еще не пуст
                if (ops.Count == 0) break;
                nums.Push(operation());
            }
        }

        static void Main(string[] str) 
        {
            setElements(getString());
            decision();            
        }
    }
}