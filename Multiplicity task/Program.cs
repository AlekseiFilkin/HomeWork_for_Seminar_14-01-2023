//Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine() ?? "0");
if (num1 % num2 == 0)
    {
        Console.Write("Первое число кратно второму");
    }
    else
    {
        int res = num1 % num2;
        Console.Write("Первое число не кратно второму, остаток от деления: " + res);
    }