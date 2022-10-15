// Задать массив из 12 элементов, заполненных числами из [-9,9]. 
// Найти сумму положительных и отрицательных элементов массива.

int[] array = new int[12];
Random random = new Random();
int posSum = 0;
int negSum = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(-9, 10);

    if (array[i] > 0)
    {
        posSum = posSum + array[i];
    }

    else
    {
        negSum = negSum + array[i];
    }
}

Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"сумма положительных чисел = {posSum}");
Console.WriteLine($"сумма отрицательных чисел = {negSum}");