// Показать последнюю цифру трёхзначного числа
Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine() ?? "0");
int y = num %10;
Console.Write("Последняя цифра трехзначного числа: " + y);

//Решение с рандомайзером:
//int num = new Random().Next(100, 1000);
//int y = num%10;
//Console.Write("Трехзначное число: " + num + " Последняя цифра трезначного числа: " + y);