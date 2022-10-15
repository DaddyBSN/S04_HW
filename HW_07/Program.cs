// Рандомно задать массив вещественных чисел.
// Найти разницу между максимальным и минимальным элементом.

int count = 0;
int max = 0;
int[] array = new int[10];
Random rand = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(0, 100);
}

int min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }

    if (array[i] < min)
    {
        min = array[i];
    }
}

count = max - min;
Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"Минимальное число = {min}");
Console.WriteLine($"Максимальное число = {max}");
Console.WriteLine($"Разница между максимальным и минимальным элементом = {count}");