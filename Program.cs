// Создадим массив через random
Random rnd = new Random();
int rows = rnd.Next(2,10);
int columns = rnd.Next(1,10);
int[,] numbers = new int[rows,columns];

// запросим у пользователя число
int num = ReadArray("Введите двухзначное число");
int[] userNum = {num/10,num%10};
//Console.WriteLine($"[{userNum[0]},{userNum[1]}]");
FillRandomArray(numbers);

int userValue = FindNumberFromArray(userNum,numbers);
if (userValue == 0)
    Console.WriteLine($"{num} -> такого числа в массиве нет");
else
    Console.WriteLine($"{num} -> {userValue}");

Console.WriteLine($"Массив [{rows},{columns}]");
PrintArray(numbers);

// Функции
int FindNumberFromArray(int[] numbers, int[,] seachArray)
{
    int result = 0;
    if(seachArray.GetLength(0) >= numbers[0]
        && seachArray.GetLength(1) >= numbers[1])
    {
        result = seachArray[numbers[0]-1,numbers[1]-1];
    }
    return result;
}

void FillRandomArray(int[,] array)
{
    Random rnd = new Random();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(0,10);
        }
    }
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j]} ");
        Console.WriteLine();
    }
}

int ReadArray(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
