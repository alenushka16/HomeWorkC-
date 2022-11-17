// Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

/*void PrintDigits(int n)
{
    Console.Write(n + " ");
    if (n >1) PrintDigits(n - 1);
}

int n = 6;
Console.Write($"N = {n} -> ");
PrintDigits(n);

// Задача 2. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumElements(int firstNum, int lastNum)
{
    if (firstNum > lastNum) return firstNum + SumElements(firstNum-1, lastNum);
    if (firstNum < lastNum) return firstNum + SumElements(firstNum + 1, lastNum);
    else return firstNum;
}

Console.Write("Input number m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number n: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = SumElements(m,n);
Console.WriteLine("The sum of natural elements in the interval from m to n: " + result);*/

//Задача 3.  Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

/*int Aс(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Aс(m - 1, 1);
    if (m > 0 && n > 0) return Aс(m - 1, Aс(m,n - 1));
    return Aс(m,n); 
}                  

Console.Write("Input non-negative number m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input non-negative number n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"m = {m}, n = {n} -> Aс(m,n) = {(m,n)}");     */ 
