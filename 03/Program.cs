// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int number = new Random().Next(10000,100000);
Console.WriteLine($"Случайное число: {number}");

int a = number / 10000;
int b = (number / 1000) % 10;
int c = ((number / 100) % 100) % 10;
int d = ((number / 10) % 100) % 10;
int e = number % 10;

if (a==e && b == d)
{
    Console.WriteLine($"Случайноее число {number} является палиндромом");
}
else
{
    Console.WriteLine($"Слуйчаное число {number} не является палиндромом");
}