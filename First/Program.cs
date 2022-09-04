Console.WriteLine("Введите два числа ");
string input1 = Console.ReadLine();
string input2 = Console.ReadLine();
int number1 = int.Parse(input1);
int number2 = int.Parse(input2);

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
