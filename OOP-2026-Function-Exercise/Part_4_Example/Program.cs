int[] data = { 1, 3, 5, 8 };

int maxD = MaxDiff(data);

Console.WriteLine("The maximum difference is " + maxD);

// Calculate the differences
int MaxDiff(int[] array)
{
    int[] diffs = new int[array.Length - 1];

    for (int i = 0; i < diffs.Length; i++)
    {
        diffs[i] = array[i + 1] - array[i];
    }

    return Max(diffs);
}



// Find the largest number.
int Max(int[] array)
{
    int max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }

    return max;
}
