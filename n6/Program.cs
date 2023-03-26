// Определить четность числа
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0) Console.Write("Число {0:d} четное", num);
else Console.Write("Число {0:d} нечетное", num);