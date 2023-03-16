// адайте двумерный массив размером m×n, 
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1



int Prompt (string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int [ , ] GenerateArray(int numberRow, int numberColumn)
{
    Random random = new Random();
    int[,] tableArray = new int[numberRow, numberColumn];
    for (int i = 0; i < tableArray.GetLength(0); i++)
    {
        for (int j = 0; j < tableArray.GetLength(1); j++)
        {
            tableArray[i,j] = random.Next(-100, 101);
        }
    }
    return tableArray;

}

void PrintArray(int[,] tableArray)
{
    Console.WriteLine();
    for (int i = 0; i < tableArray.GetLength(0); i++)
    {
        for (int j = 0; j < tableArray.GetLength(1); j++)
        {
            Console.Write($"{tableArray[i, j]}  ");
        }
        
        Console.WriteLine();
    }
}

int numRow = Prompt("Введите количестов строк массива: ");
int numColumn = Prompt("Введите количестов столбцов массива: ");

int[,] tableArray = GenerateArray(numRow, numColumn);

PrintArray(tableArray);