// // Напишите программу, которая на вход принимает число и выдаёт его 
// // квадрат (число умноженное на само себя).

// Console.Write("Insert a number: ");

// int number = Convert.ToInt32(Console.ReadLine());
// int sqrt = Convert.ToInt32(Math.Pow(number, 2));

// Console.WriteLine("Square of your number is: " + sqrt);


//2. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго
Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2 * num2)
{
    Console.Write("First number is a square of second number");
}
else
{
    Console.Write("First number is not a square of second number");
}
