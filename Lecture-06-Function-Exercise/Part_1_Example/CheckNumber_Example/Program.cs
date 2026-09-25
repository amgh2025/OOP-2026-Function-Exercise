string CheckNumber(int number)
{
    if (number > 0)
    {
        return "Positive";
    }
    else
    {
        return "Zero or negative";
    }
}

Console.WriteLine(CheckNumber(-10));
