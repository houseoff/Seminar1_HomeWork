// Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// Исходя из условия задачи, число N должно быть больше 1, так как искать числа необходимо в диапазоне от 1 до N включительно

Console.Clear();
try
{
    Console.Write("Введите число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    List<int> numbers = new();
    numbers.Add(2);
    if (n > 1)
    {
        for (int i = 4; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                numbers.Add(i);
            }
        }
        Console.WriteLine($"Четные числа в диапазоне от 1 до {n}: {string.Join(", ", numbers)}");
    }
    else
    {
        Console.WriteLine("Введите число, которое больше, чем 1");
    }
}
catch (Exception e)
{
    Console.WriteLine($"Вы ошиблись при вводе числа. Подробнее: \"{e.Message}\"");
}