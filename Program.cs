// 48. Показать двумерный массив размером m×n заполненный целыми числами

// int [,] Creat2DRandomArray (int minValue, int maxValue, int rows, int columns)
// {
//     int [,] Matrix = new int[rows , columns]; // инициализация массива

//     for (int i = 0; i < rows; i++) // задание строк
//     {
//         for (int j = 0; j < columns; j++) // задание столбцов
//         {
//             Matrix [i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return Matrix;
// }

// void Show2DArray (int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++) // задание строк
//     {
//         for (int j = 0; j < array.GetLength(1); j++) // задание столбцов
//         {
//             Console.Write(array[i,j]+ " ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("Введите минимальное значение переменной: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение переменной: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол-во строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол-во столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());


// Show2DArray(Creat2DRandomArray (minValue, maxValue, rows, columns));

// Задача 2. Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.

// int [,] Creat2DArray (int rows, int columns)
// {
//     int [,] Matrix = new int[rows , columns]; // инициализация массива

//     for (int i = 0; i < rows; i++) // задание строк
//     {
//         for (int j = 0; j < columns; j++) // задание столбцов
//         {
//             Matrix [i,j] = i + j;
//         }
//     }
//     return Matrix;
// }

// void Show2DArray (int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++) // задание строк
//     {
//         for (int j = 0; j < array.GetLength(1); j++) // задание столбцов
//         {
//             Console.Write(array[i,j]+ " ");
//         }
//         Console.WriteLine();
//     }
// }


// Console.WriteLine("Введите кол-во строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол-во столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// Show2DArray(Creat2DArray(rows,columns));

//Задача 3.Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
// и замените эти элементы на их квадраты.

//Например, изначально массив выглядел вот так:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//Новый массив будет выглядеть вот так:

//1 4 7 2
//5 **81  ** 2 **9**
//8 4 2 4


// int [,] Creat2DRandomArray (int minValue, int maxValue, int rows, int columns)
// {
//     int [,] Matrix = new int[rows , columns]; // инициализация массива

//     for (int i = 0; i < rows; i++) // задание строк
//     {
//         for (int j = 0; j < columns; j++) // задание столбцов
//         {
//             Matrix [i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return Matrix;
// }

// void Show2DArray (int [,] array)
// {
//     Console.WriteLine();
//     for (int i = 0; i < array.GetLength(0); i++) // задание строк
//     {
//         for (int j = 0; j < array.GetLength(1); j++) // задание столбцов
//         {
//             Console.Write(array[i,j]+ " ");
//         }
//         Console.WriteLine();
        
//     }
// }

// int[,] CoudValueWithOddIndex(int [,] array)
// { 
//     for (int i = 0; i < array.GetLength(0); i++) // задание строк
//     {
//         for (int j = 0; j < array.GetLength(1); j++) // задание столбцов
//         {
//             if (i % 2 == 0 && j % 2 == 0 && i != 0 && j != 0)
//             {
//                 array [i,j] = array [i,j] * array [i,j];
//             }           
//         }
//     }
//     return array;
// }


// Console.WriteLine("Введите минимальное значение переменной: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение переменной: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол-во строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол-во столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// Show2DArray(Creat2DRandomArray(minValue, maxValue, rows, columns));

// Show2DArray(CoudValueWithOddIndex(Creat2DRandomArray(minValue, maxValue, rows, columns)));


//Задача 4. Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

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
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++) // задание строк
    {
        for (int j = 0; j < array.GetLength(1); j++) // задание столбцов
        {
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
}

int[,] sumValueOnMainDiagonale(int [,] array)
{ 
    int sum = 0; // результирующая сумма
    for (int i = 0; i < array.GetLength(0); i++) // задание строк
    {
        for (int j = 0; j < array.GetLength(1); j++) // задание столбцов
        {
            if (i == j)
            {
                sum = sum + array[i, j];
            }           
        }
    }
    Console.WriteLine($"Сумма значений на главной диагонале {sum}");
    return array;
}


Console.WriteLine("Введите минимальное значение переменной: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение переменной: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());


Show2DArray(sumValueOnMainDiagonale(Creat2DRandomArray(minValue, maxValue, rows, columns)));