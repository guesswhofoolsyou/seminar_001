/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите первое число");
string numberAStr = Console.ReadLine();
int numberA = int.Parse(numberAStr);
Console.WriteLine("Введите второе число");
string numberBStr = Console.ReadLine();
int numberB = int.Parse(numberBStr);
Console.WriteLine("Введите третье число");
string numberCStr = Console.ReadLine();
int numberC = int.Parse(numberCStr);

if (numberA > numberB && numberA > numberC)
{
    Console.WriteLine($"max = {numberA}");
}
else if (numberB > numberA && numberB > numberC)
{
    Console.WriteLine($"max = {numberB}");
}        
else
{
    Console.WriteLine($"max = {numberC}");
}