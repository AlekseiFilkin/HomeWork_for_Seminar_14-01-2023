// Выяснить является ли число чётным
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine() ?? "0");
if (num %2 == 0)
    {
        Console.Write("Число четное");
    }
else 
    {
        Console.Write("Число нечетное");
    }    