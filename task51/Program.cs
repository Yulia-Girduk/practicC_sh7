// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// Вывод сообщений для пользователя по вводу данных
int Prompt (string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// Генирируем (задаем) массив случайными числами от 1 до 10
int [ , ] GenerateArray(int numberRow, int numberColumn)
{
    Random random = new Random();
    int[,] tableArray = new int[numberRow, numberColumn];
    for (int i = 0; i < tableArray.GetLength(0); i++)
    {
        for (int j = 0; j < tableArray.GetLength(1); j++)
        {
            tableArray[i,j] = random.Next(1,10);
        }
    }
    return tableArray;

}

// Находим сумму элементов на главной диагонали
int GetArray(int[,] tableArray)
{
    int sumElements = 0;
    for (int i = 0; i < tableArray.GetLength(0); i++)
    {
        for (int j = 0; j < tableArray.GetLength(1); j++)
        {
            if (i==j)
            {
                sumElements = sumElements + tableArray[i,j];
            }
        }
    }    
    return sumElements;
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
Console.WriteLine();

int sumElements = GetArray(tableArray);
Console.WriteLine($"Сумма элементов массива главной диагонали = {sumElements} ");

