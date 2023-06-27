// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Examples:    452 -> 11
//              82 -> 10
//              9012 -> 12


int digitSum(int number)
{
    //number = Math.Abs(number); // Math.Ads can be used to treat any negative numbers as positive (to use it's absolute value)
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    
    return sum;
}

int readInt(string message)
{
    Console.WriteLine(message);
    string input = Console.ReadLine();
    int number = Convert.ToInt32(input);
    return number;
}

int number = readInt("Enter a number: ");
int sum = digitSum(number);

Console.WriteLine($"The sum of all digis in {number} equals {sum}.");