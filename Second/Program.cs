Console.WriteLine("Ведите три числа ");
int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
int number3 = int.Parse(Console.ReadLine());
int max = number1;
if(max < number2)
{
    max = number2;
}
if(max < number3)
{
    max = number3;
}
Console.WriteLine($"Максимальное число {max}");
