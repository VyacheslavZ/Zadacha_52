int[,] FillMas(int n, int m)
{
    int[,] mas = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            mas[i, j] = new Random().Next(1, 10);
        }
    }
    return mas;
}

void PrintArray(int[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write("{0,3}", mas[i, j]);
        }
        Console.WriteLine("]");
    }
}

double[] AverageOfColumn(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    int sum = 0;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
            result[j] = Math.Round((double)sum / array.GetLength(0), 1);
        }
        sum = 0;
    }
    return result;
}

void PrintArray1(double[] mas)
{
    for (int i = 0; i < mas.Length - 1; i++)
    {
        Console.Write(mas[i] + "; ");
    }
    Console.Write(mas[mas.Length - 1]);
}

try
{
    System.Console.Write("Введите количество строк n = ");
    int n = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите количество столбцов m = ");
    int m = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = FillMas(n, m);
    PrintArray(newArray);
    Console.Write("Среднее арифметическое каждого столбца: ");
    PrintArray1(AverageOfColumn(newArray));
}
catch
{
    Console.WriteLine("Надо было вводить целые положительные числа!");
}