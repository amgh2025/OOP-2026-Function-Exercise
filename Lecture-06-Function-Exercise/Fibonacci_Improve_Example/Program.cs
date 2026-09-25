int Fib(int n)
{
    if (n == 0)
    {
        return 0;
    }

    int first = 0;
    int second = 1;

    for (int i = 2; i <= n; i++)
    {
        int next = first + second;

        first = second;
        second = next;
    }

    return second;
}

for (int i = 0; i < 11; i++)
{
    Console.WriteLine(i + ": " + Fib(i));
}
