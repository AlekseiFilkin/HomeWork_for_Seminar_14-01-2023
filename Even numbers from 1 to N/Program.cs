// Показать четные числа от 1 до N
Console.Write("Введите последнее число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");
int i = 1;
for (i = 1; i <= N; i++)
    if (i %2 == 0)
        {
            Console.WriteLine(i);
        }