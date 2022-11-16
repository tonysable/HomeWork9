void Recurse(int a, int b, int sum)
{
    if(a > b)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от a до b: {sum}");
        return;
    }
    sum = sum + (a++);
    Recurse(a, b, sum);
}
Recurse(4, 8, 0);