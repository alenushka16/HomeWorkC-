//Задача 1. Задайте массив заполненный случайными положительными числами.      
//Напишите программу, которая покажет количество четных чисел в массиве.       

/*int[] CreateArray(int size, int minValue, int maxValue) //тип возвращаемого значения[массив] НазваниеМЕТОДА (аргументы для его создания)
{
    int[] array = new int[size]; //создаю пустой массив = new int - это выделение памяти под массив 
        for(int i = 0; i < size; i++) // цикл (тут переменная i = 0; условие окончания цикла; увеличение i-ой каждый шаг )
    {
        array[i] = new Random().Next(minValue, maxValue+1);  // array[i] индекс, то есть i-ый элемент массива - перебираем рандомно числа и создаем массив
    }
    return array;  //возвращаем array
}

int AmountEvenNumbers(int[] array)  //тип возвращаемого значения НазваниеМЕТОДА(наш готовый массив)
{
    int amount = 0;  //инициализируем переменную и присваиваем ей значение 0
    for(int i = 0; i < array.Length; i++)   
    {
        if(array[i] % 2 == 0)   //если iый элемент массива делится на 2 без остатка 
            amount++;           //то переменная +1
    }
    return amount;   //возвращаем amount
}
 void PrintArray(int[] array)  //тип возвращаемого значения НазваниеМЕТОДА(наш готовый маасив)
 {
    Console.Write("Ваш массив: { ");      
    for(int i = 0; i < array.Length; i++)   // перебираем элементы массива и вывоим по очереди
    {
        Console.Write(array[i] + ",");    //+" " числа в массиве будут через пробел или + "," числа будут через запятую
     }
    Console.WriteLine("}");
 }
Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the minimum element: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the maximum element: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[] yourArray = CreateArray(size, minValue,maxValue); // инициализирую переменную в которую записываю результат метода  CreateArray
PrintArray(yourArray);               
int result = AmountEvenNumbers(yourArray);  //инициализирую результат и записываю в него результат метода AmountEvenNumbers
Console.WriteLine($"Amount of even numbers in your array = {result}.");
Console.ReadLine();*/

// Задача 2. Задайте одномерный массив,заполненный случайными числами. Найдите сумму элементов, стоящих на нечетных позициях.

/*int[] CreateArray(int size, int maxValue, int minValue)  //тип возвращаемого значения[массив] НазваниеМетода(аргументы)
{
    int[] array = new int[size];  //создаю пустой массив = выделяю под него память 
    for(int i = 0; i < size; i++)   //цикл(переменная i; условие окончания цикла; увеличение i-ой на шаг)
    {
         array[i] = new Random().Next(minValue, maxValue+1);   //перебираем рандомно числа и создаем из них массив
    }
    return array;
} 
void PrintArray(int[] array) //тип возвращаемого значения НазваниеМетода(аргумент - наш массив)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] +",");
        Console.WriteLine();
    }   
}
int SumElementsOfOddPositions(int[] array)
{
    int sum = 0;   //инициализирую новую величину, которая = 0
    for(int i = 1; i < array.Length; i+=2) //i-ый элемент равен 1, потому что нам нужны нечетные числа -> увеличиваем i на 2
    sum = sum + array[i];    
    return sum;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minimal number: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maximal number: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(size, maxValue, minValue);  //вызываем метод создания массива
PrintArray(myArray);    //выводим его на консоль
int result =  SumElementsOfOddPositions(myArray);   //вызываю метод нахлждения суммы элементов на нечетных позициях
Console.WriteLine($"Sum of Elements of odd position = {result}" ); 
Console.ReadLine();*/

// Задача 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным значением.

double[] CreateArray(int size)  // тип возвращаемого значения[массив] НазваниеМетода(аргумент для создания масива)
{
    double[] array = new double[size];  //создаю новый массив и выделяю ему память на устройстве
    for(int i = 0; i < size; i++)   //делаю цикл, где переменная i-ая=0;условие окончание цикла; i-ая увеличивается на 1
    {
        Console.Write($"Input element of array: ");  //вывожу на консоль текст для ввода пользователем
        array[i] = Convert.ToDouble(Console.ReadLine());  //конвертируем i-й элемент массива и получаем данные от пользователя
    }
    return array;
}
void PrintArray(double[] array)
{
    for(int i= 0; i < array.Length; i++)
    {
        Console.Write(array[i] +",");
        Console.WriteLine();
    }    
}
double DifferenceMinMax(double[] array)  
{
    double dif = 0;
    double min = array[0];  // берем 0-й элемент массива, т.к. нам нужно чтобы считалось с минимального значения элемента нашего масисива
    double max = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
            max = array[i];
        else if(array[i] < min)
            min = array[i];
    }
        dif = max - min;
    Console.WriteLine($"The maximum element = {max}.");
    Console.WriteLine($"The minimum element = {min}.");
    return dif;
}      
Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] yourArray = CreateArray(size);
PrintArray(yourArray);
double result = DifferenceMinMax(yourArray);
Console.WriteLine($"Difference between maximum and minimum array elements = {result}.");
Console.ReadLine();     