//  Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();
Console.Write("Enter a number: ");
int num = int.Parse(Console.ReadLine());
if (num % 2 == 0 & num % -2 == 0)
{
    Console.Write("It is even number");
}
else 
{
    Console.Write("It is odd number");
}

