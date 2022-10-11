//Задача 1. Напишите программу , которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*Console.Clear();
Console.Write("Input five-digit number: ");

void Palindrome(int number)

{
    int digit1 = number / 10000;
    int digit5 = number % 10;
    int digit2 = number / 1000 % 10;
    int digit4 = number /10 % 10;
        if(digit1 == digit5 && digit2 == digit4)
        Console.WriteLine($"This number is a palindrome");
        else
        Console.WriteLine($"This number is not a palindrome");
}
int number = Convert.ToInt32(Console.ReadLine());
Palindrome(number);
Console.ReadLine();*/

//Задача 2. Напишите прорамму, которая принимает на вход координаты двух точек и находит расстояние между ними в 3Д пространстве.

/*double FindDistance(double ax, double ay, double az, double bx, double by, double bz)
{
    double distance = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2) + Math.Pow(az - bz, 2));
    return distance;
}
Console.Write("enter the coordinate x point A: ");
double ax = Convert.ToDouble(Console.ReadLine());

Console.Write("enter the coordinate y point A: ");
double ay = Convert.ToDouble(Console.ReadLine());

Console.Write("enter the coordinate z point A: ");
double az = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"point A will have coordinates ({ax}, {ay}, {az}).");

Console.Write("enter the coordinate x point B: ");
double bx = Convert.ToDouble(Console.ReadLine());

Console.Write("enter the coordinate y point B: ");
double by = Convert.ToDouble(Console.ReadLine());

Console.Write("enter the coordinate z point B: ");
double bz = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"point B will have coordinates ({bx}, {by}, {bz}).");

double distance = FindDistance(ax, ay, az, bx, by, bz);
double Distance = Math.Round(distance,2);

Console.WriteLine($"Distance between point A({ax}, {ay}, {az}) and point B({bx}, {by}, {bz}) equally {Distance}");

Console.ReadLine();





//Задача 3. Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N.


 /*void CubesOfNumbersA(int n)
 {
    int count = 1;
    while(count <= n)
    {
        Console.Write($"{Math.Pow(count, 3)}"); 
        
        count++;
    }    
 }    
 Console.WriteLine("Input a number");
 int n = Convert.ToInt32(Console.ReadLine());
 CubesOfNumbersA (n);
 Console.ReadLine();*/

