int checkedIn = 0;

void CheckIn()
{
    checkedIn++;
}

for (int i = 0; i < 100; i++)
{
    CheckIn();
}

Console.WriteLine(checkedIn + " people have checked in");
