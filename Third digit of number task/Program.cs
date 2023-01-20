//Найти третью цифру числа или сообщить, что её нет
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine() ?? "0");
if (num / 100 > 0)
    {
        while (num > 1000)

        num = num / 10; 
        num = num % 10;
        Console.Write("Третья цифра числа: " + num);
    }
        
    else
    { 
        Console.Write("Третьей цифры нет");       
    }
            
