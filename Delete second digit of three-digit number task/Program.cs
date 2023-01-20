//Удалить вторую цифру трёхзначного числа
Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine() ?? "0");
int res = (num % 10) + (num / 100) * 10;
Console.WriteLine($"Удалив вторую цифру получится: {res}");