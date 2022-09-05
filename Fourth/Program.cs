Console.WriteLine("Введите число ");
int n = int.Parse(Console.ReadLine()); 
Console.WriteLine($"Все четные числа от 1 до {n}:");
for (int a = 2; a <= n; a = a + 2)
{
    Console.Write($"{a} "); 
}
Console.WriteLine();