//Задача 1. Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввел пользователь.
/*int PositiveNum(int number) // тип возвращаемого значения НазваниеМетода(аргумент )
{
    int count = 0;  //запучкаем счетчик,который изначально = 0
    for(int i = 1; i <= number; i++)  //метод где i-ая = 1, меньше или равна нашему аргументу, прибаляем к i-ой единицу 
    {
        Console.Write("Input a number: ");
        double num = Convert.ToDouble(Console.ReadLine());
        if(num>0) count++;
    }
    return count;
}

Console.Write("How many numbers do you want to enter: ");
int number = Convert.ToDouble(Console.ReadLine());
int result = PositiveNum(number);
Console.WriteLine($"Numbers greater than 0 = {result}");
Console.ReadLine();*/

//Задача 2. Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями
// y=k1*x+b1, y=k2*x+b2, значения b1,k1,b2 и k2 задает пользователь

void CrossPoint(double b1, double b2, double k1, double k2) //тип метода войд НазваниеМетода(аргументы, которые вводит пользователь)
{
    double x = (b2-b1)/(k1-k2); 
    double y = k1*x+b1;
    Console.WriteLine($"Cross Point = [{y} {x}]: ");
}


Console.WriteLine("Input b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
CrossPoint(b1,b2,k1,k2);