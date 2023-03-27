// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//  возводит число A в натуральную степень B. (Задачи, решенные через Math.Pow, не будут считаться правильными, 
//  так как задача стоит в том, чтобы написать цикл)

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


// Console.Write("Введите число A: ");
// int A = int.Parse(Console.ReadLine()!);

// Console.Write("Введите число B (степень): ");
// int B = int.Parse(Console.ReadLine()!);

// int stepen = A;
// {
//     for(int i = 1; i <= B ; i++)
//     {
//         stepen = stepen * A;
//     }
//     Console.WriteLine($"A в степени В равно: " + stepen);
// }




// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// int Length = Length(number);
// Console.WriteLine($"Сумма цифр в числе {number} равно {getsum(number, Length)}");

// int getsum (int number, int lenght)
// {
//     int sum = 0;
//     for (int i = 1; i <= lenght; i++)
//     {
//         sum = sum + number % 10;
//         number /= 10;
//     }
//     return(sum);
// }




// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)

// Console.WriteLine("Введите массив из 8 элементов:  ");
// int number = int.Parse(Console.ReadLine()!);

// int[] array = new int[number];
// for (int i = 0; i < number; i++)
// {
//     array[i] = new Random().Next(number+1);
//     Console.Write(array[i] +  "; ");
// }
// Console.WriteLine();