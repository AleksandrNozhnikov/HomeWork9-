// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите начальное число ");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите конечное число ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PrintNum(M, N));

int PrintNum(int start, int end)
{
    if (start==end)
    {
        return end;
    }
    return(start +PrintNum(start + 1, end));
}