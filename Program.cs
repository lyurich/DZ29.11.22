// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4


Console.Write("Введите элементы(через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

GetMas(arr);


void GetMas(int[] array)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Кол-во элементов > 0: {count}");

}


// Задача 43: Написать программу, которая на вход принимает массив из любого количества элементов 
// (не менее 6)в промежутке от 0 до 100, а на выходе выводит этот же массив, но отсортированный по возрастанию
// (от меньшего числа к большему).

// int[] array = GetArray(10, 0, 100);
// Console.WriteLine($"Изачальный массив: [{String.Join(", ", array)}]");
// Console.WriteLine($"Отсортированный массив: [{String.Join(", ", SortMas(array))}]");

// int[] SortMas(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {

//         for (int j = 0; j < array.Length - 1; j++)
//         {
//             if (array[j] > array[j + 1])
//             {
//                 int temp = array[j];
//                 array[j] = array[j + 1];
//                 array[j + 1] = temp;
//             }
//         //}
//     }
//     return array;
// }

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return result;
// }