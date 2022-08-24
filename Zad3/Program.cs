// Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива [3 7 22 2 78] -> 76 

Console.Write("Введите любое число (количество элементов массива): ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
double result = 0;
double max = 0;
double min = 0;
FillArrayRandomNumbres(numbers);
PrintArray(numbers);

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
}

result = max - min;
Console.WriteLine("Разница между максимальным и минимальным элементом равна " + result);

void FillArrayRandomNumbres(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(-50, 50)) / 10.0;
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}