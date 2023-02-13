//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на
// старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.

using static System.Console;
Clear();

WriteLine("Введите числа, слова или символы через пробел: ");
string[] array1 = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
string[] array2 = new string[array1.Length];

GetArray(array1, array2);
WriteLine();
PrintArray(array2);

void GetArray(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
    if(arr1[i].Length <= 3)
        {
        arr2[count] = arr1[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]} ");
    }
    WriteLine();
}


    

