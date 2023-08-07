string[] Fillarray(string[] your_array)
{
    int length = your_array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine("Enter any characters");
        your_array[i] = Console.ReadLine()!;
        
    }
    return your_array;
}

void PrintArray(string[] stringArray)
{
    int arrayLength = stringArray.Length;
    for (int j = 0; j < arrayLength; j++)
    {
        Console.Write(stringArray[j] + " ");
    }
}

int Count(string[] stringArray)
{
    int stringArrayLength = stringArray.Length;
    int count = 0;

    for (int m = 0; m < stringArrayLength; m++)
    {
        if (stringArray[m].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] CreateNewArray(string[] fullArray, int size)
{
    int arraySize = size;
    string[] newArray = new string[size];
    int index = 0;
    for (int k = 0; k < fullArray.Length; k++)
    {
        if (fullArray[k].Length <= 3)
        {
            newArray[index] = fullArray[k];
            index++;
        }
    }
    return newArray;
}


Console.WriteLine("Enter array length ");
int array_length = int.Parse(Console.ReadLine()!);
string[] array = new string[array_length];
string[] stringArray = Fillarray(array);
PrintArray(stringArray);
Console.WriteLine();
int count = Count(stringArray);
Console.WriteLine();
string[] desiredArray = CreateNewArray(stringArray, count);
PrintArray(desiredArray);
