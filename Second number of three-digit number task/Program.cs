// Показать вторую цифру трёхзначного числа
Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine() ?? "0");
while (num >= 100)
{
    num /= 10;
}
int res = num %10;
Console.Write("Вторая цифра трехзначного числа: " + res);
