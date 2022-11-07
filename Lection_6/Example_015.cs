// Лекция 6:
// Тема : Как не нужно писать код.
// Патерны и антипатерны.

// Задача: Есть строка, в которой находятся парные координаты точек фигуры. 
//         Увеличить каждую из координат в два раза и показать пользователю ответ. 

// Парсинг входной строки
// Parsing - метод принимает входные данные из строки и возвращает другой тип данных.

/*
using System.Linq;               // что это?

string text = "(1,2) (2,3) (4,5) (9,7)"
                .Replace("(","")            
                .Replace(")","")        
                ;                       
Console.WriteLine(text);                 
var date = text.Split(" ")            
               .Select(item => item.Split(',')) 
               .Select(e => (x: int.Parse(e[0]),y: int.Parse(e[1]))) // массив картежей??? что?
               .Where(e => e.x % 2 == 0)  // Что за .Where?
               .Select(point => (point.x*10, point.y*10))
               .ToArray();    // Явный массив???             
for (int i = 0; i < date.Length; i++)
{
    Console.WriteLine(date[i]);
}
*/