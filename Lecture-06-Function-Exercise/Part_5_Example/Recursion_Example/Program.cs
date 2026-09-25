CountDown(3);

void CountDown(int number)
{
    if (number == 0)
    {
        return;
    }

    Console.WriteLine(number);

    CountDown(number - 1);
}
