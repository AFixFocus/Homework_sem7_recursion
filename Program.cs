// Задача 1.
//  Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N. Использовать рекурсию, 
// не использовать циклы.

// Console.WriteLine("Write number M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Write number N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// if (m > n)
// {  
//     int temp = 0;
//     temp = m;
//     m = n;
//     n = temp;
// }

// void ReadNumbers(int m, int n)
// {
//     if  (m > n)
//     {  
//         return;
//     }

// Console.Write($" {m}, ");
// ReadNumbers(m+1,n); 
// }
// ReadNumbers(m,n);

// Задача 2. 
// Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.

// Console.Write("Write first positive number: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Write second positive number: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int functionAkkerman(int m, int n)
// {
//     if (m == 0) 
//     {
//         return n + 1;
//     }
//     else if (n == 0) 
//     {
//         return functionAkkerman(m-1, 1);
//     }
//     else 
//     {
//         return functionAkkerman(m-1, functionAkkerman (m, n-1));
//     }
// }

// Console.Write($"Result calculation function by Akkerman : {functionAkkerman(m, n)} ");


// Использовалась реализация цункции Аккермана следующая:
// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))
// Оптимальные числа, чтоб не заполнить стэк, нашла 3 и 10)

// Задача 3. 
// Задайте произвольный массив. Выведете его элементы, 
// начиная с конца. Использовать рекурсию, не использовать циклы.

int[] array = { 1, 2, 3, 4, 5 };
ShowReversArray(array, array.Length - 1);

void ShowReversArray(int[] array, int lastIndex)
{
    if (lastIndex < 0)
    {
        return;
    }
    Console.WriteLine(array[lastIndex]);
    ShowReversArray(array, lastIndex-1);
}
