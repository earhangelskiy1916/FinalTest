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


Console.WriteLine("Enter array length ");
int array_length = int.Parse(Console.ReadLine()!);
string[] array = new string[array_length];
string[] stringArray = Fillarray(array);
