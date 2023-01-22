// Вычисление факториала. Рекурсия.

double Factorial(int n)
{
 // 1! = 1
 // 0! = 1
 if(n == 1) return 1;
 else return n * Factorial(n-1);
}
for (int i = 1; i < 40; i++)
{
 Console.WriteLine($"{i}! = {Factorial(i)}");
}

// E + 29 означает, что получившееся число нужно умножить на 10 в 29 степени.
