// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
// string NumbersRec (int n)
// {
//    if (n>=1) return $"{n}, " + NumbersRec(n-1);
//    else return String.Empty;
// }
// Console.Write("Введите целое число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(NumbersRec(n));


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
//элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int SummNums (int m, int n)
// {
//     if(m<=n) return m + SummNums(m+1, n);
//     else return 0;
// }

// Console.Write("Введите натуральное число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// if (m<=0) 
// {
//     Console.WriteLine("Введеное число не является натуральным. Натуральное число - положительные числа от 1 до бесконечности");
//     Console.Write("Введите натуральное число: ");
//     m = Convert.ToInt32(Console.ReadLine());
// }

// Console.Write("Введите натуральное число, большее введенного ранее: ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n<=0) 
// {
//     Console.WriteLine("Введеное число не является натуральным. Натуральное число - положительные числа от 1 до бесконечности");
//     Console.Write("Введите натуральное число: ");
//     n = Convert.ToInt32(Console.ReadLine());
// }

// int temp=n;
// if(n<m)
// {
//     Console.WriteLine($"Первое введенное число меньше второго, поэтому сумму элементов будем считать от {n} до {m}.");
//     n=m;
//     m=temp;
// }


// Console.WriteLine($"Сумма чисел от {m} до {n} составляет: {SummNums(m,n)}");

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkerman (int m, int n)
{
    if (m==0) return n+1;
    else if ((m>0) & (n==0)) return Akkerman(m-1,1);
    else return Akkerman(m-1, Akkerman(m, n-1));
}

Console.Write("Введите число больше 0: ");
int m = Convert.ToInt32(Console.ReadLine());
if (m<=0) 
{
    Console.WriteLine("Введеное число отрицательное или равно 0");
    Console.Write("Введите число больше 0: ");
    m = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Введите число больше 0: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n<=0) 
{
    Console.WriteLine("Введеное число является отрицательным или равно 0");
    Console.Write("Введите число больше 0: ");
    n = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"А ({m} , {n}) = {Akkerman(m,n)}");





