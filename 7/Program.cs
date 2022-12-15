// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса neчётные, 
// и замените эти элементы на их квадраты.

// task 48


// void InputMatrix(int[, ] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(-10, 11);
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }

// void DMatrix(int[, ] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i%2==1&&j%2==1)
//             {
//                 matrix[i, j]=matrix[i,j]*matrix[i,j];
//             }
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }

void InputMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void ReleaseMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 1 && j % 2 == 1)
            {
                matrix[i, j] *= matrix[i, j];
            }
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] coord = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
Console.WriteLine("Начальная матрица: ");
InputMatrix(matrix);
Console.WriteLine("Результат: ");
ReleaseMatrix(matrix);

// Console.Clear();
// Console.Write("Введите размер матрицы: ");
// int[] coord = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
// int[,] matrix = new int[coord[0], coord[1]];
// InputMatrix(matrix);
// DMatrix(matrix);
