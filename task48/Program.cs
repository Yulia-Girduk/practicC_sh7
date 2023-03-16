// Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// Вывод сообщений для пользователя по вводу данных
int Prompt (string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// Генирируем (задаем) массив по формуле Aₘₙ = m+n. 
int [ , ] GenerateArray(int numberRow, int numberColumn)
{
    int[,] tableArray = new int[numberRow, numberColumn];
    for (int i = 0; i < tableArray.GetLength(0); i++)
    {
        for (int j = 0; j < tableArray.GetLength(1); j++)
        {
            tableArray[i,j] = i+j;
        }
    }
    return tableArray;

}

// Вывод массива на экран
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