//Задайте значения M и N. Напишите программу,
//которая найдёт сумму натуральных элементов 
//в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.WriteLine("Введите начальное число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите конечное число: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumNum(n, m));

int SumNum(int start, int end)
{
    if (start > end)
    {

        return 0;

    }
    return (start + SumNum(start + 1, end));
}