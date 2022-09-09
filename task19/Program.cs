//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Write("Введите пятизначное число: ");
string? num1 = Console.ReadLine();

void CheckingNumber(string num1){
  if (num1[0]==num1[4] || num1[1]==num1[3]){
    Console.WriteLine($"Число: {num1} - палиндром.");
  }
  else Console.WriteLine($"Число {num1} - не палиндром.");
}
if (num1!.Length == 5){
  CheckingNumber(num1);
}
else Console.WriteLine($"Число не подходит.");
