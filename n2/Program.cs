// Сравнение двух введенных чисел
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2) Console.WriteLine("Число {0:d} больше", num1);
else 
    if (num1 < num2) Console.WriteLine("Число {0:d} больше",num2);
    else Console.WriteLine("Вы ввели два одинаковых числа");