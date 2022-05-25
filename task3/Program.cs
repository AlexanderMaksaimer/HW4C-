// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


void FillArray(int[] collection)
{
    Random rnd = new Random();
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = rnd.Next(0,99999);
    }
}

int [] array = new int [8];
FillArray(array);
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}


