/*Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Введите число");
string userNumberStr = Console.ReadLine();
int userNumber = int.Parse(userNumberStr);
for (int result = 2; result < userNumber; result++)
{   
    if (result % 2 == 0)
    Console.Write ($"{result} ");
}