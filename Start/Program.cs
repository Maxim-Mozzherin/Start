string name = "Tom";  // определяем переменную и инициализируем ее

Console.WriteLine(name);    // Tom

name = "Bob";       // меняем значение переменной
Console.WriteLine(name);    // Bob


// Константы


const string NAME = "Tom";  // определяем константу
/*  -----Пример ошибки-----
1.     const string NAME;  // ! Ошибка - константа NAME не инициализирована
2.     const string NAME = "Tom";  // определяем константу
NAME = "Bob";   // !Ошибка - у констаты нельзя изменить значение 
*/