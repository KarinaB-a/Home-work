Console.WriteLine("Введите число ");
int N = int.Parse(Console.ReadLine()); 
Console.WriteLine($"Все четные числа от 1 до {N}:");
for (int A = 1; A <= N; A++)
{
    if(A%2 == 0)
    {
        Console.Write($"{A} ");
    }
}
