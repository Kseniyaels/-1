/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.WriteLine("Введите три числа");
string number1 = Console.ReadLine() ?? "";
string number2 = Console.ReadLine() ?? "";
string number3 = Console.ReadLine() ?? "";
int num1 = Convert.ToInt32(number1);
int num2 = Convert.ToInt32(number2);
int num3 = Convert.ToInt32(number3);

if (num1 > num2 & num1 > num3)
{
    Console.WriteLine($"Число {num1} максимальное");
}
if (num2 > num1 & num2 > num3)
{
    Console.WriteLine($"Число {num2} максимальное");
}
if (num3 > num1 & num3 > num2)
{
    Console.WriteLine($"Число {num3} максимальное");
}
if (num1 == num2 & num1 == num3) 
{
    Console.WriteLine($"Все числа равны");
}
