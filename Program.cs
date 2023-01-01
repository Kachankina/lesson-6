// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3



// Console.Write("Insert numbers:");
// int numbers = int.Parse(Console.ReadLine()!);

// int [] array = new  int [numbers];

// void GetMassiveNum(int[]coll)
// {
//     for(int index = 0; index < coll.Length; index++)
//     {
//         Console.Write($"Insert{index +1}number");
//         coll[index]= int.Parse(Console.ReadLine()!);

//     }
// }
// int TheSumNum(int[] coll) 
// {
//     int count = 0;
//     for(int index =0; index < coll.Length; index++)
//     {
//         if(coll[index] > 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }  
// GetMassiveNum(array);
// Console.WriteLine();
// Console.WriteLine(TheSumNum(array));


// Console.Write("Введите числа через запятую: ");
// int[] numbers = StringToNum(Console.ReadLine()!);
// PrintArray(numbers);
// int sum = 0;
// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] > 0)
//     {
//         sum++;
//     }
// }
// Console.WriteLine();
// Console.WriteLine($"количество значений больше 0 = {sum}");


// int[] StringToNum(string input)
// {
//     int count = 1;
//     for (int i = 0; i < input.Length; i++)
//     {
//         if (input[i] == ',')
//         {
//             count++;
//         }
//     }

//     int[] numbers = new int [count];
//     int index = 0;

//     for (int i = 0; i < input.Length; i++)
//     {
//         string temp = "";

//         while (input [i] != ',')
//         {
//         if(i != input.Length - 1)
//         {
//             temp += input [i].ToString();
//             i++;
//         }
//         else
//         {
//             temp += input [i].ToString();
//             break;
//         }
//         }
//         numbers[index] = Convert.ToInt32(temp);
//         index++;
//     }
//     return numbers;
// }


// void PrintArray(int[] array)
// {
//     Console.Write("[ ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.Write("]");
// }

// Console.WriteLine($"Кол-во элементов > 0: {count}");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// Console.Clear();
// Console.Write("Insert b1, k1, b2, k2 with space:");
// string[] f = Console.ReadLine().Split();
// double b1 = double.Parse(f[0]);
// double k1 = double.Parse(f[1]);
// double b2 = double.Parse(f[2]);
// double k2 = double.Parse(f[3]);

// void InterCrossNumber(double b01, double kx1, double b02, double kx2)
// {
//     double[] result = new double [2];
//     result[0] = (b02-b01) / (kx1 - kx2);
//     result[1] = kx1 * result[0] + b01;
//     for(int i = 0; i < result.Length; i++)
//     {
//         Console.WriteLine($"{result[i]}");
//     }
// }
// InterCrossNumber(b1, k1, b2, k2);
// //if(a1 > 0 && a2 >0 && a01 > 0 && a02 >0)
// //{
     
//     Console.WriteLine();
//     Console.WriteLine($"Answer:crosspoint is here => x = {x}, y = {y}");
//     Console.WriteLine();
// //}
