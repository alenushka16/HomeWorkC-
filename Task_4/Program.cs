//Задача 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/* int GiveNumberDegree (int A, int B)

{
    int res;
    res = (int) (Math.Pow(A,B));
    return res;
}
Console.Write("Input digit A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Input digit B: ");
int B = Convert.ToInt32(Console.ReadLine());

int numDegree = GiveNumberDegree (A, B);
Console.WriteLine ($"Digit {A} in degree {B} = {numDegree}");
Console.ReadLine();*/

//Задача 2. Напишите прогамму, которая принимает на вход число и выдает сумму цифр в числе. 

/*int SumDigits(int number)
{
    int sum = 0;
    string num = number.ToString();
    int size = num.Length;
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = (int)char.GetNumericValue(num[i]); 
        for(int j =i; j < size; j++)
            sum = sum + array[j];  
    }
    return sum; 
      
}
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = SumDigits(number);
Console.WriteLine(result);
Console.ReadLine();*/

//Задача 3. Напишите программу, которая задает массив из m элементов и выводит их на экран.

int[] CreateArray(int size);

    int[] array = new int[size];
     for(int i = 0; i < size; i++)
        {
            Console.Write("Введите элемент массива: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
    return array; 

void PrintArray(int [] newArray)
{
    for(int i = 0; i < newArray.Length; i++)
        Console.Write(newArray[i] + " ");
    Console.WriteLine();
}
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] YourArray = CreateArray(size);
Console.ForegroundColor = ConsoleColor.Green;
PrintArray(YourArray);
Console.ReadLine();