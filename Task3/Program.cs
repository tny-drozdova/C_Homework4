// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// Examples:     1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//               6, 1, 33 -> [6, 1, 33]

int[] GenerateArray(int length)  // the method to generate random numbers
{
    int[] array = new int[length];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next();
    }

    return array;
}

void PrintArray(int[] array)  // the method to print the elements of array
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}

int[] numbers = GenerateArray(8); // declaring the variable Numbers and calling for the array of 8 digits 
PrintArray(numbers);
