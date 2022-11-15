// Задача 1.
// Собрать строку с числами от a до b ( a <= b)
/*
string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
        result += $"{i} ";
    return result;
}
// { для обратного заполнения....
//     string result = String.Empty;
//     for (int i = b; i >= a; i--)
//         result += $"{i} ";
//     return result;
// }
// Обычный метод

string NumbersRes(int a, int b)
{
    if (a <= b) return  $"{a} " + NumbersRes(a + 1, b)";
    else return String.Empty;
}
// { для обратного заполнения`
//     if (a <= b) return NumbersRes(a + 1, b) + $"{a} ";
//     else return String.Empty;
// }
// Рекурсивный метод.
Console.WriteLine(NumbersFor(1, 10)); //1 2 3 4 5 6 7 8 9 10
Console.WriteLine(NumbersRes(1, 10)); //1 2 3 4 5 6 7 8 9 10

// Чтобы поменять заполнение строки от большего к меньшему:
// for (int i = a; i >= b; i--) в первом случае изменим условие.
// а во втором поменяем возвращаемый результат : Сначала метод затем
// строка заполнения...
*/