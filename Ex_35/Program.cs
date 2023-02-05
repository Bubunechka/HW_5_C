// Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150].
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5

int[] RandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++);
    {
        array[i] = new Random().Next(leftRange, rigthRange); // + 1;
    }
    
    return array;
}

int[] massive = RandomArray(123, 0, 150);
Console.WriteLine(string.Join(" , ", massive));
int sum = 0; // кол-во элементов в промежутке

for(int k = 10; k <= 99; k++) //значения лежат в отрезке [10,99]
{
    if(massive[i] > 0)
    {

        int count = 0;
        count++;
        sum += massive[i];
    }
}

Console.WriteLine($"Количество элементов в промежутке равно {sum}");