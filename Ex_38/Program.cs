// Задача 38: Задайте массив натуральных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int a = 0;
int i = 0;
int n = 0;
int sum = 0;
int sumo = 0;
int[] m = new int [100];

Random rand = new Random();
n = 11;
Console.WriteLine("Исход]щий массив"); 
for (i = 0; i < n; i++)
{
    m[i] = rand.Next(1,100);
    Console.Write(m[i] + " ");
}

var min = m[0];
var max = m [0];

for(i = 0; i < n; i++)
{
    if(m[i] < min)
    {
        min = m[i];
    }
    else if (m[i] > max)
    {
        max = m[i];
    }

}
int qwotient; 
qwotient = max - min;

Console.WriteLine(" Частное  между max и min: " + qwotient);

//Console.WriteLine("Минимальный элемент: " + min);
//Console.WriteLine("Максимальный элемент: " + max);
//for(i = 0; i < n; i++)
//{
//    Console.Write(m[i] + " ");
//}
