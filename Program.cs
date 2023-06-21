// Задача 41: Пользователь вводит с клавиатуры M 
// чисел. Посчитайте, сколько чисел больше 0 ввёл 
// пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int Promt(string message)
// {
//     Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// int [] InputArray(int length)
// {
//     int [] array = new int[length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Promt($"Введите {i + 1}-й элемент");
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.WriteLine($"a[{i}] = {array[i]}");
//     }
// }

// int CountPositiveNumbers(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// int length = Promt("Введвите колличество элементов >");
// int [] array = InputArray(length);
// PrintArray(array);
// Console.WriteLine($"Колличество чисел больше 0 - {CountPositiveNumbers(array)}");


// Задача 43: Напишите программу, которая найдёт 
// точку пересечения двух прямых, заданных 
// уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

const int COEFFICIENT = 0;
const int CONSTANT = 1;
const int X_COORD = 0;
const int Y_COORS = 1;
const int LINE1 = 1;
const int LINE2 = 2;

double[] lineData1 = InputLineData(LINE1);
double[] lineData2 = InputLineData(LINE2);

if(ValidateLines(lineData1, lineData2)
{
    double[] coord = FindCoords(lineData1, lineData2);
    Console.WriteLine($"Точка пересечения уравнений y = {lineData1[COEFFICIENT]}* x + {lineData1[CONSTANT]} и y = {lineData2[COEFFICIENT]}* x + {lineData2[CONSTANT]} ");
    Console.WriteLine($" имеет координаты({coord[X_COORD]}, {coord[Y_COORD]})");
    
}

