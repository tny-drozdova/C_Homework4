// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Examples: 3, 5 -> 243 (3⁵)
//           2, 4 -> 16

int readInt(string message)
{
    Console.WriteLine(message);
    string number = Console.ReadLine();
    int parsedNumber = Convert.ToInt32(number);
    return parsedNumber;
}

int numA = readInt("Enter the base number (A): ");
int numB = readInt("Enter the exponent (B): ");

int result = 1;
int count = 1;

while (count <= numB)
{
    result *= numA;
    count++;
}

Console.WriteLine($"{numA} raised to the power of {numB} equals: {result}");