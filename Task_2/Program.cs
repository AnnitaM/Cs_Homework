// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 ->  max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.WriteLine("Enter first number: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int num2 = int.Parse(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine($"The number {num1} is greater than the number {num2}");
}
else
{
    Console.WriteLine($"The number {num1} is less than the number {num2}");
}
//if (num1 == num2)
//{Console.WriteLine($"The number  {num1} is equal to the number {num2}");}
