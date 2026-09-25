int Fib(int n)
{
    if (n == 0)
    {
        return 0;
    }
    else if (n == 1)
    {
        return 1;
    }
    else
    {
        return Fib(n - 1) + Fib(n - 2);
    }
}

for (int n = 0; n < 11; n++)
{
    Console.WriteLine(n + ": " + Fib(n));
}
