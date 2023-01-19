//Проверка, не является ли число 1 квадратом 2ого числа
Console.Write("Введите первое целое число: ");
int num1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе целое число: ");
int num2 = int.Parse(Console.ReadLine() ?? "0");
if (num1 == num2 * num2)
    {Console.Write("Первое число " + num1 + " является квадратом второго числа " + num2);

    }
else 
    {Console.Write("Первое число " + num1 + " не является квадратом второго числа " + num2);

}