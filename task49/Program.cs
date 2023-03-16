// Задайте двумерный массив. Найдите элементы, 
// у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть 
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

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

// Замена элемента с четными индексами на их квадраты
int [ , ] GetArray(int[,] tableArray)
{
    int[,] arrayEven = new int[tableArray.GetLength(0), tableArray.GetLength(1)];
    for (int i = 0; i < tableArray.GetLength(0); i++)
    {
        for (int j = 0; j < tableArray.GetLength(1); j++)
        {
            if ((i%2 == 0) && (j%2==0))
            {
                arrayEven[i,j]= tableArray[i,j]*tableArray[i,j];
            }
            else
            {
               arrayEven[i,j]= tableArray[i,j]; 
            }
        }
        
    }    
    return arrayEven;
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

int[,] arrayEven = GetArray(tableArray);
PrintArray(arrayEven);


