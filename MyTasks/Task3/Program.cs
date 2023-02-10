//Напишите программу, в которой пользователь вводит с клавиатуры букву.
// Программа должна вывести " буква гласная" если введённая буква гласная и соответственно с согл. буквой.

using static System.Console;
Clear();

WriteLine("Введите русскую букву: ");
string letter = ReadLine()!;
        switch (letter)
        {
            case "а":
        WriteLine("буква гласная");
        break;
          case "у":
        WriteLine("буква гласная");
        break;
          case "о":
        WriteLine("буква гласная");
        break;
          case "ы":
        WriteLine("буква гласная");
        break;
           case "и":
        WriteLine("буква гласная");
        break;   
          case "э":
        WriteLine("буква гласная");
        break;
          case "я":
        WriteLine("буква гласная");
        break;
        case "ю":
        WriteLine("буква гласная");
        break;
        case "е":
        WriteLine("буква гласная");
        break;
        case "ё":
        WriteLine("буква гласная");
        break;
        default:
        WriteLine("буква согласная");
        break;
        }
