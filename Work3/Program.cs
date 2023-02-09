/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */
int[,] array = new int[2, 2];
Generate2DArray(array);
Print2DArray(array);

Console.WriteLine();

int[,] resultArray = new int[2, 2];
int[,] secondArray = new int[2, 2];
Generate2DArray(secondArray);
Print2DArray(secondArray);

if (array.GetLength(0) != secondArray.GetLength(1))
{
    Console.WriteLine(" Неккоректные значения ");
    return;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            resultArray[i, j] = resultArray[i, j] + array[i, k] * secondArray[k, j];
        }
    }
}

System.Console.WriteLine();
Print2DArray(resultArray);

void Generate2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5);
        }
    }
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}