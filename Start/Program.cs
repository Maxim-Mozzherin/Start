// Преобразование базовых типов данных

byte a = 4;
byte b = a + 70;  // ошибка

/*
Дело в том, что операция сложения (да и вычитания) возвращает значение типа int,
если в операции участвуют целочисленные типы данных с разрядностью меньше или равно int (то есть типы byte, short, int).
Поэтому результатом операции a + 70 будет объект, который имеет длину в памяти 4 байта.
Затем этот объект мы пытаемся присвоить переменной b, которая имеет тип byte и в памяти занимает 1 байт. 
 */

byte a1 = 4;
byte b1 = 70;
byte a2 = (byte)(a1 + b1); // работает

byte a3 = 4;
byte b3 = (byte)(a3 + 70); //работает

//Сужающие и расширяющие преобразования
/*

byte -> short -> int -> long -> decimal

int -> double

short -> float -> double

char -> int


 Все безопасные автоматические преобразования можно описать следующей таблицей:
 byte ==>> short, ushort, int, uint, long, ulong, float, double, decimal

sbyte ==>> short, int, long, float, double, decimal

short ==>> int, long, float, double, decimal

ushort ==>> int, uint, long, ulong, float, double, decimal

int ==>> long, float, double, decimal

uint ==>> long, ulong, float, double, decimal

long ==>> float, double, decimal

ulong ==>> float, double, decimal

float ==>> double

char ==>> ushort, int, uint, long, ulong, float, double, decimal
 
 */