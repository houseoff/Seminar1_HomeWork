// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
try
{
    Console.Write("Введите первое число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int m = Convert.ToInt32(Console.ReadLine());
    if (n > m)
        Console.WriteLine($"Максимальное из чисел {n} и {m}: {n}");
    else if (n < m)
        Console.WriteLine($"Максимальное из чисел {n} и {m}: {m}");
    else
        Console.WriteLine($"Числа {n} и {m} равны");
}
catch (Exception e)
{
    Console.WriteLine($"Вы ошиблись при вводе числа. Подробнее: \"{e.Message}\"");
}
