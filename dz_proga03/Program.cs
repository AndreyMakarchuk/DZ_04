// Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.

int size = 8;
int[] array = new int[size];
FillArray(array);
PrintArray(array);

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
}
void PrintArray(int[] array)
{
    Console.Write($"Массив из {size} элементов -> [ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}