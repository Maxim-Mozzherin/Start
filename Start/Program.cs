string hello = "Привет мир";
Console.WriteLine(hello);
Console.WriteLine("Добро пожаловать в C#!");
Console.WriteLine("Пока мир...");
Console.WriteLine(24.5);

//Ниже пример интерполяци, использующийся для вывода нескольких переменных в одну строку
string name = "Tom";
int age = 34;
double height = 1.7;
/*
Для встраивания отдельных значений в выводимую на консоль строку используются фигурные скобки, в которые заключается встраиваемое значение. 
Это можем значение переменной ({name}) или более сложное выражение (например, операция сложения {4 + 7}). А перед всей строкой ставится знак доллара $.
*/
Console.WriteLine($"Имя: {name}  Возраст: {age}  Рост: {height}м");

//пример вывода с помощью плейсхолдеров
string name1 = "Tom";
int age2 = 34;
double height3 = 1.7;
//в фигурных скобках указывается порядковый номер переменных, перечисленных через запятую в конце инструкции
Console.WriteLine("Имя: {0}  Возраст: {2}  Рост: {1}м", name1, height3, age2);

// Console.Write отличается от WL, тем что не переводит на следующую строку
string _name = "Tom";
int _age = 34;
double _height = 1.7;
//в учебнике не показан пример, если сделать так, то будет видно отличие
Console.Write($"Имя: {_name}  Возраст: {_age}  Рост: {_height}м ");
Console.Write($"Имя: {_name}  Возраст: {_age}  Рост: {_height}м ");

// Консольный ввод
Console.Write("Введите свое имя: ");
string? name_ = Console.ReadLine();
Console.WriteLine($"Привет {name_}");

// Ниже пример взаимодействия с данными, введенными пользователем для конвертации в нужный тип, т.к. изначально это string
Console.Write("Введите имя: ");
string? Name = Console.ReadLine();

Console.Write("Введите возраст: ");
int Age = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите рост: ");
double Height = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите размер зарплаты: ");
decimal salary = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine($"Имя: {Name}  Возраст: {Age}  Рост: {Height}м  Зарплата: {salary}$");