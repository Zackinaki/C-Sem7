// task 38
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным
//  элементов массива.
// [3 7 22 2 78] -> 76

void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(new Random().NextDouble() * (10 - 1) + 1, 2);
}


void DiffMaxMin(double[] array)
{
    double minArray = array[0], maxArray = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minArray)
            minArray = array[0];
        else if (array[i] > maxArray)
            maxArray = array[i];
    }
    Console.WriteLine($"Результат: {maxArray - minArray}");
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
DiffMaxMin(array);
