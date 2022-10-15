// Найти сумму чисел одномерного массива стоящих на нечетной позиции

int[] array = new int[10];
Random random = new Random();
int sum = 0;

for (int i = 1; i < array.Length; i++)
{
    array[i] = random.Next(0, 100);
}

for (int i = 0; i < array.Length; i = i + 2)
{
    sum = array[i] + sum;
}

Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"Сумма чисел на нечетной позиции = {sum}");