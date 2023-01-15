// // Напишите функцию, которая принимает на вход градусы по Цельсию и возвращает градусы по фаренгейту.
// Результат должен быть округлен до 1 знакапосле точки.

using static System.Console;
Clear();

WriteLine("Введите градусы по Цельсию: ");
float degrees = float.Parse(ReadLine()!);

float farengeit = GetFarengeit(degrees);
WriteLine($"{degrees} по Цельсию равно {farengeit} по фаренгейту.");


float GetFarengeit(float X)
{
  float res = (X * 9/5) + 32; 
   return res;
}
