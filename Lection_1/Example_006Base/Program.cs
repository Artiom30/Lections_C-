int a = 1;           //   
int b = 2;           //   
int c = 6;           //     Ввод данных
int d = 8;           //       
int e = 4;           //       

int max = a;         //     Временная переменная

if ( a > max ) max = a;     //
if ( b > max ) max = b;     //
if ( c > max ) max = c;     //    Тело программы... 
if ( d > max ) max = d;     //
if ( e > max ) max = e;     //

Console.WriteLine("max = " + max);      //  Вывод результата