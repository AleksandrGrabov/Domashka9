 Console.WriteLine("Введите значение M:");
    int M = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите значение N:");
    int N = int.Parse(Console.ReadLine());

    Console.WriteLine(GetNaturalNumbers(M, N));

   string GetNaturalNumbers(int current, int end)
{
    if (current == end)
    {
        return current.ToString();
    }
    else
    {
        return current.ToString() + ", " + GetNaturalNumbers(current + 1, end);
    }
}