int[] intArr = new int[5];

int[] oneArr = Fill(intArr, -2);

// Print the array
for (int i = 0; i < oneArr.Length; i++)
{
    Console.Write(oneArr[i] + " ");
}


int[] Fill(int[] array, int value)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = value;
    }

    return array;
}
