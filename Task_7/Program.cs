//Задайте двумерный массив размером m*n, заполненный случайными вещественными числами.
/*double [,] CreateArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a minimal possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a maximal possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
    double[,] array = new double [rows, columns];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue+1);
            return array;
}
void PrintArray (double[,] array)
{
     for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
             Console.WriteLine();
    }
}
double[,] myArray = CreateArray();
PrintArray(myArray);*/

//Напишите программау, которая принимает на вход позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание,
//что такого элемента нет.

/*int [,] CreateArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a minimal possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a maximal possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
    int[,] array = new int [rows, columns];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue+1);
            return array;
}
void PrintArray (int[,] array)
{
     for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
             Console.WriteLine();
    }
}
void FindNumber(int[,]array)
{
    Console.Write("Input number of index i : ");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of index j : ");
    int j = Convert.ToInt32(Console.ReadLine());
    
    if((i >= 0 && i < array.GetLength(0)) && (j >= 0 && j < array.GetLength(1)))
        Console.WriteLine($"Element with indexes [{i},{j}] = {array[i, j]}");
    else 
    Console.WriteLine($"There is no element under this index");
}

int [,] myArray = CreateArray();
PrintArray(myArray);
FindNumber(myArray);*/

//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int [,] CreateArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a minimal possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a maximal possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
    int[,] array = new int [rows, columns];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue+1);
            return array;
}
void PrintArray (int[,] array)
{
     for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
             Console.WriteLine();
    }
}              

double[] AverageValue(int[,] array)
{

    double[] newarray = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
            sum = sum + array[i, j];
        newarray[j] = Math.Round((sum / array.GetLength(0)),1);
    }  
    return newarray;
}
void PrintDoubleArray(double[] array)
{
    Console.Write("Arithmetic mean: { ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("}.");
}

int[,] myArray=CreateArray();
double[] newarray = AverageValue(myArray);
PrintDoubleArray(newarray);
PrintArray(myArray);

Console.ReadLine();