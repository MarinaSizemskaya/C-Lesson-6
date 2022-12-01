// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


using System;
using static System.Console;
Clear();

WriteLine("Введите несколько чисел через пробел: ");
int [] array =GetArrayFromString(ReadLine());

int[] GetArrayFromString(string arrayString)
{
    string[] nums = arrayString.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[nums.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = Convert.ToInt32(nums[i]);
    }
    return result;
}

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i]>0)
    {
        count++;
    }
}

WriteLine($"В данном массиве {count} чисел больше 0");