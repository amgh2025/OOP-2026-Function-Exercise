// 1. No return value
void SayHello()
{
    Console.WriteLine("Hello");
}

// 2. Return a value
int Add(int a, int b)
{
    return a + b;
}

// 3. Return can stop a function at if (early)
void CheckNumber(int number)
{
    if (number < 0)
    {
        return;
    }

    Console.WriteLine(number);
}

// Call SayHello
SayHello();

// Call Add function
int answer = Add(10, 20);

Console.WriteLine(answer);

// Call Check Number
CheckNumber(-5);
