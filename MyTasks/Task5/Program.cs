// пользователь кроме номера операции вводит и два числа, и в зависимости от номера операции 
//с введенными числами выполняются определенные действия (например, при вводе числа 3 числа умножаются).
// Результат операции выводится на консоль (только в том случае, когда операция известна)
// "Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение"

// ДВА ВАРИАНТА:

// using System;
// using static System.Console;
// public class MainClass
// {
//     public static void Main()
//     {
//         WriteLine("Введите номер операции: 1 - Сложение 2 - Вычитание 3 - Умножение");
//         int operation = int.Parse(ReadLine()!);
//         WriteLine("Введите 2 числа через пробел: ");
//         string line = ReadLine()!;
//         string[] splitString = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

//         double a = Convert.ToDouble(splitString[0]);
//         double b = Convert.ToDouble(splitString[1]);
//         double result = 0;
       
//        switch (operation)
//         {
//             case 1:
//             result = a + b;
//         WriteLine($"Результат операции {result}");
//         break;
//           case 2:
//           result = a - b;
//         WriteLine($"Результат операции {result}");
//         break;
//           case 3:
//           result = a * b;
//         WriteLine($"Результат операции {result}");
//         break;
//          default:
//         WriteLine("Неизвестная операция!");
//         break;
//         }


//     }
// }







using System;
using static System.Console;
public class MainClass

{
    public static void Main()
    {
        WriteLine("Введите номер операции: 1 - Сложение 2 - Вычитание 3 - Умножение");
        int operation = int.Parse(ReadLine()!);
        double result = 0;
       
       switch (operation)
        {
            case 1:
            WriteLine("Введите 2 числа: ");

        double a = double.Parse(ReadLine()!);
        double b = double.Parse(ReadLine()!);
            result = a + b;
        WriteLine($"Результат операции {result}");
        break;
          case 2:
            WriteLine("Введите 2 числа: ");

        double x = double.Parse(ReadLine()!);
        double y = double.Parse(ReadLine()!);
          result = x - y;
        WriteLine($"Результат операции {result}");
        break;
          case 3:
          WriteLine("Введите 2 числа: ");
        double n = double.Parse(ReadLine()!);
        double m = double.Parse(ReadLine()!);
          result = n * m;
        WriteLine($"Результат операции {result}");
        break;
         default:
        WriteLine("Неизвестная операция!");
        break;
         }


    }
}
