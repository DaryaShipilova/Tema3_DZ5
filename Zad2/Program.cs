// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите любое число (количество элементов массива): ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
int sum = 0;
FillArrayRandomNumbres(numbers);
PrintArray(numbers);

for (int i = 1; i < numbers.Length; i+=2)
        sum += numbers[i];

Console.WriteLine("Сумма элементов, стоящих на нечетных позициях равна " + sum);

void FillArrayRandomNumbres(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-50, 51);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}