// Задача 3 :
// Факториал числа N
/*
// Обычный метод :
int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= i;
    return result;
}

// Рекурсивный метод:
int FactorialRec(int n)
{
    if (n == 1) return 1;
    else return n * FactorialRec(n - 1);
}

Console.WriteLine(FactorialFor(5)); // 120
Console.WriteLine(FactorialRec(5)); // 120
*/