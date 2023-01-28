// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
using System.Text.RegularExpressions;

// Блок 1. Пользователь вводит три числа по очереди. 
// Раскомментируйте блок, чтобы проверить. Закомментируйте, что бы проверить другой блок
// =====================================================================================
// Console.Clear();
// try
// {
//     Compares numbers = new();
//     Console.Write("Введите первое число: ");
//     numbers.Add(Convert.ToInt32(Console.ReadLine()));
//     Console.Write("Введите второе число: ");
//     numbers.Add(Convert.ToInt32(Console.ReadLine()));
//     Console.Write("Введите третье число: ");
//     numbers.Add(Convert.ToInt32(Console.ReadLine()));
//     Console.WriteLine($"Максимальное из чисел {string.Join(", ", numbers)}: {numbers.Max()}");
// }
// catch (Exception e)
// {
//     Console.WriteLine($"Вы ошиблись при вводе числа. Подробнее: \"{e.Message}\"");
// }
// =====================================================================================

// Блок 2. Пользователь вводит три числа (или более) сразу через разделитель (например, запятую)
// Раскомментируйте блок, чтобы проверить. Закомментируйте, что бы проверить другой блок
// =============================================================================================
Console.Clear();
Console.Write("Введите числа через запятую: ");
string str = Console.ReadLine()!;
Compares numbers = new();

foreach (string number in str.Split(","))
{
    string n = number.Trim();
    if (Regex.IsMatch(n, @"^\d+$"))
        numbers.Add(Convert.ToInt32(n));
}

if (numbers.Count == 0)
    Console.WriteLine("Некорректный ввод. Необходимо ввести числа через запятую");
else if (numbers.Count == 1)
    Console.WriteLine("Введите хотя бы два числа для сравнения");
else
    Console.WriteLine($"Максимальное из чисел {string.Join(", ", numbers)}: {numbers.Max()}");
// =============================================================================================

// Класс Compares, который унаследован от класса List, содержащий метод Max (нахождение максимума из n элементов)
public class Compares : List<int>
{
    public int Max()
    {
        int max = this[0];
        foreach (int e in this)
        {
            if (e > max)
                max = e;
        }
        return max;
    }
}
