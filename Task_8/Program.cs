// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.Clear(); 
Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());
int i = 1;
if (number < 1)
{
    Console.Write("Enter a number grater than 1");
    return;
}
while (i <= number)
{
    if (i % 2 == 0)
    {
      Console.Write($"{i} ");  
    }
    i ++; 
}