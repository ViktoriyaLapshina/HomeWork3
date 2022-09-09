// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int count = 1;
for (count = 1; count <= num1; count++)
{
    Console.WriteLine(count * count * count);
}



