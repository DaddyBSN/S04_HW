// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

void PrintArray(int[] arr)
{
    int count = arr.Length;
    int index = 0;
    while (index < count)
    {
        Console.Write(arr[index] + " ");
        index++;
    }
}

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(0, 2);
        index++;
    }
}

int[] array = new int[8];
int count = array.Length;

FillArray(array);
PrintArray(array);