// Напишите программу, в который пользователь вводит цифру от 1 до 31.  То есть день месяца.  
// Учитывая что 1 число, это понедельник, программа должна выводить какой сегодня день недели.

using static System.Console;
Clear();

WriteLine("Введите цифру, обозначающую день месяца: ");
int a = int.Parse(ReadLine()!);

int x = a%7;

        switch (x)
        {
            case 1:
        WriteLine("Понедельник");
        break;
          case 2:
        WriteLine("Вторник");
        break;
          case 3:
        WriteLine("Среда");
        break;
          case 4:
        WriteLine("Четверг");
        break;
           case 5:
        WriteLine("Пятница");
        break;   
          case 6:
        WriteLine("Суббота");
        break;
          case 0:
        WriteLine("Воскресенье");
        break;
        }