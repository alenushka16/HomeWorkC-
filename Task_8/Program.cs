// Задача 1. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

/*int[,] Create2dArray()
{
    Console.Write("Input the number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input minimal element of array: "); 
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input maximal element of array: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}
void Print2dArray(int[,] array)
{
    Console.WriteLine("Your array is: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}
int[,] ChangeElementsRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, j])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, j];
                    array[i, j] = temp;
                }
            }
        }
    }
    return array;
}
int[,] newArray = Create2dArray();
Print2dArray(newArray);
Console.WriteLine();
int[,] changeArray = ChangeElementsRows(newArray);
Print2dArray(changeArray);*/



// Задача 2. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


/*int[,] Create2dArray()
{
    Console.Write("Input the number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input minimal element of array: "); 
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input maximal element of array: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}
void Print2dArray(int[,] array)
{
    Console.WriteLine("Your array is: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}


int[] SumElementsRows(int[,] array)
{
    int[] sumArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
            sumArray[i] = sum;
        }
    }
    return sumArray;
}
void PrintSumArray(int[] array)
{
    Console.Write("Sum of elements: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
            Console.Write(", ");
    }
    Console.WriteLine();
}
int IndexMinElements(int[] array)
{
    int iMin = 0;
    int min = array[iMin];
    for (int i = 1; i < array.Length - 1; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            iMin = i;
        }
    }
    return iMin;
}
int[,] newArray = Create2dArray();
Print2dArray(newArray);
Console.WriteLine();
int[] sumArray = SumElementsRows(newArray);
PrintSumArray(sumArray);
int numberOfRow = (IndexMinElements(sumArray) + 1);
Console.WriteLine($"The number of the row with the minimal sum of elements - {numberOfRow}.");*/




// Задача 3. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.

/*int[] TwoDigitNumbers()
{
    int[] array = Enumerable.Range(10, 90).ToArray();
    for (int i = 0; i < array.Length; i++)
    {
        int j = new Random().Next(0, 90);
        if (j != i)
        {
            var temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
    return array;
}
int[,,] Create3DArray(int[] array, int height, int width, int depth)
{
    int m = 0;
    int[,,] array3D = new int[height, width, depth];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                array3D[i, j, k] = array[m];
                m++;
            }
        }
    }
    return array3D;
}
void Print3DArray(int[,,] array)
{
    Console.WriteLine("\nElements and inexes in 3D array: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k] + " ");
                Console.Write($"({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

try
{
    Console.Write("Input the number of rows: ");
    int height = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the number of columns: ");
    int width = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the depth of array: ");
    int depth = Convert.ToInt32(Console.ReadLine());
    int[] array = TwoDigitNumbers();
    int[,,] array3D = Create3DArray(array, height, width, depth);
    Print3DArray(array3D);
}
catch(Exception)
{
    Console.WriteLine("\nInvalid input!");
}*/
// Задача 4.  Напишите программу, которая заполнит спирально массив 4 на 4.


/*int[,] GetSquareSpiral(int rows, int columns)
{
    int[,] arraySpiral = new int[rows, columns];
    for (int passage = 0, valueElements = 1; valueElements <= rows * columns; passage++)
    {
        for (int i = passage, j = passage; j < columns - passage; j++)
        {
            arraySpiral[i, j] = valueElements;
            valueElements++;
        }
        if(valueElements > rows * columns) break;
        for (int i = passage + 1, j = columns - passage - 1; i < rows - passage; i++)
        {
            arraySpiral[i, j] = valueElements;
            valueElements++;
        }
        if(valueElements > rows * columns) break;
        for (int i = rows - passage - 1, j = columns - passage - 2; j >= passage; j--)
        {
            arraySpiral[i, j] = valueElements;
            valueElements++;
        }
        if(valueElements > rows * columns) break;
        for (int i = rows - passage - 2, j = passage; i > passage; i--)
        {
            arraySpiral[i, j] = valueElements;
            valueElements++;
        }
    }
    return arraySpiral;
}
void PrintArraySpiral(int[,] array, int fillZeros = 2)
{
    Console.WriteLine("\nAn array filled spirally: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j].ToString($"D{fillZeros}") + " "); 
        Console.WriteLine();
    }
}
try
{
    Console.Write("Input the number of row: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] arraySpiral = GetSquareSpiral(rows, columns);
    PrintArraySpiral(arraySpiral);
}
catch(Exception)
{
    Console.WriteLine("\nInvalid input");
}
Console.ReadLine();
*/