Console.WriteLine("Введите значение M:");
    int M = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите значение N:");
    int N = int.Parse(Console.ReadLine());

    int sum = GetNaturalSum(M, N);
    Console.WriteLine("Сумма натуральных элементов: " + sum);

   int GetNaturalSum(int start, int end)
{
    if (start > end)
    {
        return 0;
    }
    else
    {
        return start + GetNaturalSum(start + 1, end);
    }
}