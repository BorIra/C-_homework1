// Принять число N и вывести все четные от 1 до N
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int chet = 2;

Console.Write("Четные числа до {0:d}: ", num); 

if (chet > num)  Console.WriteLine(" таких нет");

while (chet <= num)
{
    Console.Write(" {0:d},", chet);
    chet += 2;
}