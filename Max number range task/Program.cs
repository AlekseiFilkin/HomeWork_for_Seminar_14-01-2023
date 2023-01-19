//Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int num = new Random().Next(10, 100);
Console.WriteLine($"Загаданное число: {num}");
//Console.Write("Введите число от 10 до 99: ");
//int num = int.Parse(Console.ReadLine() ?? "0");
int max = num %10;
while ( num != 0 )
    {
        num = num /= 10;
        
        if (num%10 > max)
            max = num %10;
    }
Console.WriteLine($"Макcимальная цифра числа равна {max}");