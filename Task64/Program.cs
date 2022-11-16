void Recurse(int digit)
{
    Console.WriteLine(digit);
    if(digit > 1)
    {
        Recurse(digit - 1);
    }
}

Recurse(5);