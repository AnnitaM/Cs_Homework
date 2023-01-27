// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.Write("Enter first number: ");
string firstStr = Console.ReadLine();
int num1 = Convert.ToInt32(firstStr);
Console.Write("Enter second number: ");
string secondtStr = Console.ReadLine();
int num2 = Convert.ToInt32(secondtStr);
Console.Write("Enter third number: ");
string thirdtStr = Console.ReadLine();
int num3 = Convert.ToInt32(thirdtStr);
if ( num1 > num2 & num1 > num3 ) // Оператор & вычисляет логическое И для всех своих операндов. Результат операции x & y принимает значение true, если оба оператора x и y имеют значение true. В противном случае результат будет false.
    {
   Console.WriteLine($"The greater number is first number {num1}.");
    }
if (num2 > num1 & num2 > num3 ) 
    {
   Console.WriteLine($"The greater number is second number {num2}.");
    }
if (num3 > num1 & num3 > num2 ) 
    {
    Console.WriteLine($"The greater third number is number {num3}.");
    }
if (num1 == num2 & num1 == num3)
{
    Console.WriteLine($"All three numbers are equal.");
}

