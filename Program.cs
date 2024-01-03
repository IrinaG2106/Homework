// Задача 1: Задайте одномерный массив из 10 целых
// чисел от 1 до 100. Найдите количество элементов
// массива, значения которых лежат в отрезке [20,90].

// массив [10 21 14 93 23] => 2

// int n = 10;
// int check = 0;
// int[]array = new int[n];

// for(int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(1, 101);

// for(int i = 0; i < array.Length; i++)
//     Console.Write(array [i]+" ");

// Console.WriteLine();

// for(int i = 0; i < array.Length; i++)
//     if  (array[i]>19 && array[i]<91)
//     {
//     check++;
//     }
    
//     Console.WriteLine(check);

//...........................................

// Задача 2: Задайте массив на 10 целых чисел.
// Напишите программу, которая определяет
// количество чётных чисел в массиве.
// массив [6 7 19 34 3 1 4 7 9 1] => 3
// массив [1 8 43 4 55 60 3 2 1 3] => 4

// int n = 10;
// int check = 0;
// int[]array = new int[n];

// for(int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(1, 20);

// for(int i = 0; i < array.Length; i++)
//     Console.Write(array [i]+" ");

// Console.WriteLine();

// for(int i = 0; i < array.Length; i++)
//     if  (array[i]%2 ==0)
//     {
//     check++;
//     }
    
//     Console.WriteLine(check);

//..................................................

// Задача 3: Задайте массив из вещественных чисел с
// ненулевой дробной частью. Найдите разницу между
// максимальным и минимальным элементов массива. 

// массив [2.2 0.4 9.11 7.2 78.98] => 78.58
// массив [1.22 4.5 3.33] => 3.28

// int n = 10;
// double[]array = new double[n];

// for(int i = 0; i < array.Length; i++)
//     array[i] = Math.Round((new Random().NextDouble() + new Random().Next(1,10)),2);

// for(int i = 0; i < array.Length; i++)
//     Console.Write(array [i]+" ");
//      Console.WriteLine();

// double min = array[0];
// for(int i = 1; i < array.Length; i++)
//     if (array[i]<min) min = array[i];
//     //  Console.WriteLine(min);
    

// double max = array[0];
// for(int i = 1; i < array.Length; i++)
//     if (array[i]>max) max = array[i];
//     // Console.WriteLine(max);

// Console.WriteLine(max-min);
// ............................................................

// Задача 4**(не обязательно): Дано натуральное
// число в диапазоне от 1 до 100 000. Создайте массив,
// состоящий из цифр этого числа. Старший разряд
// числа должен располагаться на 0-м индексе
// массива, младший – на последнем. Размер массива
// должен быть равен количеству цифр
// 425 => [4 2 5]
// 8741 => [8 7 4 1]
// 4 => [4]

// 