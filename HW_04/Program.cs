// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] array = new int[123];
Random random = new Random();
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(0, 110);

    if (array[i] >= 10 && array[i] <= 99)
    {
        count++;
    }
}

Console.WriteLine(string.Join(", ", array));
Console.WriteLine(count);