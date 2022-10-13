void Zadacha54()
{
    //Задача 54: Задайте двумерный массив.
    //Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] array = new int[rows, columns];
    FillArray(array);
    PrintArray(array);
    SortArray(array);
    Console.WriteLine();
    PrintArray(array);
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] array)
{
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(0, 15);
        }
    }
}

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

void Zadacha56()
{
    //Задача 56: Задайте прямоугольный двумерный массив.
    //Напишите программу, которая будет находить строку с наименьшей суммой элементов.

    int[,] array = new int[4, 6];
    FillArray(array);
    PrintArray(array);
    NumberMinStroka(array);
}

void NumberMinStroka(int[,] array)
{
    int index = 0,
        minsum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (i == 0)
        {
            minsum = sum;
        }
        else if (sum < minsum)
        {
            minsum = sum;
            index = i;
        }
    }
    Console.WriteLine($"Строка с минимальной суммой элементов равна {index + 1} = {minsum}");
}

void Zadacha58()
{
    //Задача 58: Напишите программу, которая заполнит спирально массив 4 на 4.
    int size = 4;
    int[,] array = new int[size, size];
    FillArraySpiral(array, size);
    PrintArray2(array);
}

void FillArraySpiral(int[,] array, int size)
{
    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= size * size)
    {
        array[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < size - 1)
            j++;
        else if (i < j && i + j >= size - 1)
            i++;
        else if (i >= j && i + j > size - 1)
            j--;
        else
            i--;
    }
}

void PrintArray2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else
                Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

//Zadacha54();
//Zadacha56();
Zadacha58();
