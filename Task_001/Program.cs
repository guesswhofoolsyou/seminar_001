/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите первое число");
string numberFirstStr = Console.ReadLine();
int numberFirst = int.Parse(numberFirstStr);
Console.WriteLine("Введите второе число");
string numberSecondStr = Console.ReadLine();
int numberSecond = int.Parse(numberSecondStr);

if (numberFirst > numberSecond)
    Console.Write($"max={numberFirst}, min={numberSecond}");
else
    Console.Write($"max={numberSecond}, min ={numberFirst}");