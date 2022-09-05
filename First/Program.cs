Console.WriteLine("Введите два числа ");
int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());

if(number1 > number2)
{
    Console.WriteLine($"большее число {number1}");
    Console.WriteLine($"меньшее число {number2}");
}
else if(number1 < number2) 
{
    Console.WriteLine($"большее число {number2}");
    Console.WriteLine($"меньшее число {number1}");
}
else
{
    Console.WriteLine($"числа равны");
}
