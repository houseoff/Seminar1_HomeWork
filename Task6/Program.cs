// Задача 6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
Console.Clear();
try
{
    Console.Write("Введите число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (n % 2 == 0)
        Console.WriteLine($"Число {n} - чётное");
    else
        Console.WriteLine($"Число {n} - нечётное");
}
catch (Exception e)
{
    Console.WriteLine($"Вы ошиблись при вводе числа. Подробнее: \"{e.Message}\"");
}
