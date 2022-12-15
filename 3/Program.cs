// Вася не любит английский язык, но каждый раз старается получить хотя бы четверку за четверть,
//  чтобы оставаться ударником. В текущей четверти Вася заметил следующую закономерность: по нечетным
//   дням месяца он получал тройки, а по четным – четверки. Так же он помнит, в какие дни он получал
//    эти оценки. Поэтому он выписал на бумажке все эти дни для того, чтобы оценить, сколько у него
//     троек и сколько четверок. Помогите Васе это сделать, расположив четные и нечетные числа в 
//     разных строчках. Вася может рассчитывать на оценку 4, если четверок не меньше, чем троек.

int n = Convert.ToInt32(Console.ReadLine());
string[] numbers = Console.ReadLine().Split(" ");
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = int.Parse(numbers[i]);


int countEven = 0, countOdd = 0;
foreach (int element in array)
{
    if (element % 2 == 1)
    {
        Console.Write($"{element} ");
        countEven++;
    }
}
Console.WriteLine();
foreach (int element in array)
{
    if (element % 2 == 0)
    {
        Console.Write($"{element} ");
        countOdd++;
    }
}
Console.WriteLine();
if (countOdd > countEven)
    Console.WriteLine("YES");
else
    Console.WriteLine("NO");
