//Задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// void ShowNumbers(int n)
// {
//     if (n > 1) ShowNumbers(n - 1);
//     Console.Write($"{n} ");
// }


// Console.WriteLine("Enter n");
// int n = Convert.ToInt32(Console.ReadLine());
// ShowNumbers(n);


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int SumBetweenNumbers(int m, int n)

{
    int sum = 0;
    for (int i = Math.Min(m, n); i <= Math.Max(m, n); i++)
    {
        sum = sum + i;
    }
    return sum;
}


Console.WriteLine("Enter n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter m");
int m = Convert.ToInt32(Console.ReadLine());
int result = SumBetweenNumbers(m, n);
Console.WriteLine(result);