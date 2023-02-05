//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


int[] RandomArray(int size)
{
    int[] array = new int[8];
    for(int i = 0; i < array.Length; i++)
    {
    array[i] = new Random().Next(size);
    }

return array;
}

//Console.Write("bbb");

int[] massive = RandomArray(8);
Console.WriteLine(string.Join(", ", massive));
int sumP = 0; // сумма положительных
int a = 0;

for(int i = 0; i <= massive.Length; i++)
{
    if(massive[i] > 0) // является ли положительным?
    {
        int count = 0;
        sumP = count / 2 !=0;
        count++;
        //int num = num + massive[i];
        sumP += massive[i];
    }
   
}

Console.WriteLine($"Сумма элементов равна {sumP}");