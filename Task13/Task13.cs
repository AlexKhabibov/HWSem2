// Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Input number"); 
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your number is " + number);
if (number < 1000)
{
    if (number > 99)
    {
    number = number % 10; 
    Console.WriteLine("Your number is " + number); 
    }
    else
    {
    Console.WriteLine("Youre number has no third figure");
    }
}
else
{
    Console.WriteLine("Incorrect input");
}