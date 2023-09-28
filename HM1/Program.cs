// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//Console.WriteLine("Insert first number");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Insert second number");
//int num2 = Convert.ToInt32(Console.ReadLine());

//if (num1 > num2)
//{
//    Console.WriteLine("First number is bigger");
//}
//else
//{
//    Console.WriteLine("Second is bigger");
//}
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//Console.WriteLine("Insert first number");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Insert second number");
//int num2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Insert third number");
//int num3 = Convert.ToInt32(Console.ReadLine());
//
//if (num1 > num2 && num1 > num3)
//{
//    Console.WriteLine(" Num1 is biggest");
//}
//else if (num2 > num1 && num2 > num3)
//{
//    Console.WriteLine(" Num2 is biggest");
//}
//else Console.WriteLine("Num3 is biggest");

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//Console.WriteLine("Insert number");
//int num = Convert.ToInt32(Console.ReadLine());
//
//if (num % 2 == 0)
//{
//    Console.WriteLine("Число четное");
//}
//else Console.WriteLine("Число нечетное");

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.WriteLine("Insert number");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i <= n)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
        i++;
    }
    else
    {
        i++;
    }
}