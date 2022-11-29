// 48. Показать двумерный массив размером m×n заполненный целыми числами

int [,] Creat2DRandomArray (int minValue, int maxValue, int rows, int columns)
{
    int [,] Matrix = new int[rows , columns]; // инициализация массива

    for (int i = 0; i < rows; i++) // задание строк
    {
        for (int j = 0; j < columns; j++) // задание столбцов
        {
            Matrix [i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return Matrix;
}

void Show2DArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) // задание строк
    {
        for (int j = 0; j < array.GetLength(1); j++) // задание столбцов
        {
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
}

Show2DArray(Creat2DRandomArray (0, 9, 4, 5));
