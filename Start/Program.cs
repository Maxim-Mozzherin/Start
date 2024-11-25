// Условные конструкции. Практическое задание.
/*
 Напишите консольную программу, в которую пользователь вводит с клавиатуры два числа.
А программа сранивает два введенных числа и выводит на консоль результат сравнения 
(два числа равны, первое число больше второго или первое число меньше второго).
 */
using System.ComponentModel.Design;

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());



if (number1 > number2)
{
    Console.WriteLine($"{number1} больше чем {number2}");
}
else if (number1 < number2)
{
    Console.WriteLine($"{number1} меньше чем {number2}");
}
else
{
    Console.WriteLine($"{number1} равно {number2}");
}

/*
Напишите консольную программу, в которую пользователь вводит с клавиатуры число. 
Если число одновременно больше 5 и меньше 10, то программа выводит "Число больше 5 и меньше 10". 
Иначе программа выводит сообщение "Неизвестное число".
 */

Console.WriteLine("Введите число");
int number =  Convert.ToInt32(Console.ReadLine());

int lowRange = 5;
int highRange = 10;

if (number > lowRange & number < highRange)
    Console.WriteLine("Число больше 5 и меньше 10");
else
    Console.WriteLine("Неизвестное число");

/*
Напишите консольную программу, в которую пользователь вводит с клавиатуры число. 
Если число либо равно 5, либо равно 10, то программа выводит "Число либо равно 5, либо равно 10". Иначе программа выводит сообщение "Неизвестное число".
 */

Console.WriteLine("Введите число");
int number3 = Convert.ToInt32(Console.ReadLine());

int lowRange3 = 5;
int highRange3 = 10;

if (number3 == lowRange3 | number2 == highRange3)
    Console.WriteLine("Число либо равно 5, либо равно 10");
else
    Console.WriteLine("Неизвестное число");


