// Задача 10. Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Input 3x number");
int number = Convert.ToInt32(Console.ReadLine());

int number2 = number % 100 / 10;

Console.WriteLine("Your number is " + number2);