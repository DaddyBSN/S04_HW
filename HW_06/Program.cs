// Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.

Console.Write("Сколько чисел в массиве разбить на пары? ");
int quan = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[quan];
int[] arrayResult = new int[array.Length / 2 + array.Length % 2];
Random random = new Random();
int num = array.Length;

if (quan % 2 != 0)
{
    Console.WriteLine("Мы не можем разбить на пары нечетное количество чисел...");
}

else
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1, 10);
    }
    Console.WriteLine(string.Join(", ", array));

    for (int i = 0; i < arrayResult.Length; i++)
    {
        arrayResult[i] = array[i] * array[array.Length - 1 - i];
    }

    if (array.Length % 2 != 0)
    {
        arrayResult[arrayResult.Length - 1] = array[array.Length / 2];
    }

    Console.WriteLine("Произведение пар чисел: ");
    Console.WriteLine(string.Join(", ", arrayResult));
}