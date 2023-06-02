// Задача 38: Задайте массив вещественных(тип double) чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3,1; 7,2; 22,3; 2,4; 78,5] -> 76,1

double[] FillArrayWithRandomNumber(int size)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1, 10) + Math.Round(rnd.NextDouble(), 2);
    }
    return arr;
}


System.Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
double[] array = FillArrayWithRandomNumber(length);
System.Console.WriteLine(string.Join("; ", array));
 
double max = 0;
double min = 10;
double sub = 0;
for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    sub = max - min;
System.Console.WriteLine($" Разница между максимальным и минимальным элементов массива равна: {sub}");