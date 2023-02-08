/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] GetArray( int m, int n, int minValue, int maxValue) // Генерация двумерного массива
{
    int[,] result = new int[m, n];
    for (int row = 0; row < m; row++)
    {
        for (int column = 0; column < n; column++)
        {
            result[row, column] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray) // Вывод массива на консоль
{
    for (int row = 0; row < inArray.GetLength(0); row++)
    {
        for (int colunm = 0; colunm < inArray.GetLength(1); colunm++)
        {
            Console.Write($"{inArray[row, colunm]}\t ");
        }
        Console.WriteLine();
    }
}

double[] Average(int[,] matrix)
{
    double[] average = new double[matrix.GetLength(1)];
    for(int column = 0; column < matrix.GetLength(1); column++)
    {
        double total = 0;
        for(int row = 0; row < matrix.GetLength(0); row++)
        {
            total += matrix[row, column];
        }
        total /= matrix.GetLength(0);
        average[column] = total;
    }
    return average;
}

void Main() // Административная функция
{
    Console.Clear();
    int[,] ourArray = GetArray(4, 4, 0, 10);
    PrintArray(ourArray);
    double[] average = Average(ourArray);
    Console.WriteLine($"{string.Join(" ", average)} -> среднее арифметическое каждого столбца массива");
}

Main();