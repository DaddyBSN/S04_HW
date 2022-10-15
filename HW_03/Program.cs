// Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных/четных чисел.

int[] array = new int[10];
Random random = new Random();
int countEven = 0;
int countOdd = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(100, 1000);

    if (array[i] % 2 == 0)
    {
        countEven++;
    }

    else
    {
        countOdd++;
    }
}

Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"Количество нечетных чисел в массиве: {countOdd}");
Console.WriteLine($"Количество четных чисел в массиве: {countEven}");